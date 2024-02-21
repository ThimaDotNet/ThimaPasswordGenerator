#nullable enable
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace PasswordToolbox;

/// <summary>
///     A robust utility class for generating secure passwords and evaluating their strength.
/// </summary>
public class PasswordGenerator
{
	#region Fields, Static Fields and Constants

	#region Fields, Static Fields, and Constants

	private readonly Random _random = new();

	#endregion

	private int _passwordLength = 8;

	#endregion

	/// <summary>
	///     Default constructor for the PasswordGenerator class.
	/// </summary>
	public PasswordGenerator()
	{
	}

	/// <summary>
	///     Parameterized constructor for the PasswordGenerator class with customizable options.
	/// </summary>
	/// <param name="length">The desired length of the password (default is 8).</param>
	/// <param name="lowercaseChars">Custom lowercase characters for the password (default is all lowercase letters).</param>
	/// <param name="uppercaseChars">Custom uppercase characters for the password (default is all uppercase letters).</param>
	/// <param name="numbers">Custom numeric characters for the password (default is 0-9).</param>
	/// <param name="specials">Custom special characters for the password (default is common symbols).</param>
	public PasswordGenerator(int? length, string? lowercaseChars, string? uppercaseChars, string? numbers,
		string?                   specials)
	{
		ValidatePasswordLength(length);
		PasswordLength = length ?? 8;

		LowercaseCharacters = lowercaseChars ?? "abcdefghijklmnopqrstuvwxyz";
		UppercaseCharacters = uppercaseChars ?? "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		NumberCharacters    = numbers        ?? "0123456789";
		SpecialCharacters   = specials       ?? "!@#$%^&*()_ +";
	}

	/// <summary>
	///     Gets or sets the string containing lowercase characters for password generation.
	/// </summary>
	public string LowercaseCharacters { get; set; } = "abcdefghijklmnopqrstuvwxyz";

	/// <summary>
	///     Gets or sets the string containing uppercase characters for password generation.
	/// </summary>
	public string UppercaseCharacters { get; set; } = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

	/// <summary>
	///     Gets or sets the string containing numeric characters for password generation.
	/// </summary>
	public string NumberCharacters { get; set; } = "0123456789";

	/// <summary>
	///     Gets or sets the string containing special characters for password generation.
	/// </summary>
	public string SpecialCharacters { get; set; } = "!@#$%^&*()_ +";

	/// <summary>
	///     Gets or sets the length of the generated password.
	/// </summary>
	public int PasswordLength
	{
		get => _passwordLength;
		set
		{
			ValidatePasswordLength(value);
			_passwordLength = value;
		}
	}

	/// <summary>
	///     Generates a password with specified character types and calculates its strength.
	/// </summary>
	/// <param name="includeUpper">Include uppercase characters.</param>
	/// <param name="includeLower">Include lowercase characters.</param>
	/// <param name="includeNumbers">Include numeric characters.</param>
	/// <param name="includeSpecial">Include special characters.</param>
	/// <returns>A tuple containing the generated password and its strength.</returns>
	public (string password, int strength) GeneratePassword(bool includeUpper, bool includeLower, bool includeNumbers,
		bool                                                     includeSpecial)
	{
		ValidateCharacterTypes(includeUpper: includeUpper, includeLower: includeLower, includeNumbers: includeNumbers,
			includeSpecial: includeSpecial);

		StringBuilder characters = new();
		AppendCharacters(characters: characters, include: includeLower,   characterSet: LowercaseCharacters);
		AppendCharacters(characters: characters, include: includeUpper,   characterSet: UppercaseCharacters);
		AppendCharacters(characters: characters, include: includeNumbers, characterSet: NumberCharacters);
		AppendCharacters(characters: characters, include: includeSpecial, characterSet: SpecialCharacters);

		ValidateCharacterSet(characters);

		char[] password = new char[PasswordLength];
		for (int i = 0; i < PasswordLength; i++)
		{
			password[i] = characters[_random.Next(characters.Length)];
		}

		return (new(password), CalculateStrength(new(password)));
	}

	/// <summary>
	///     Calculates the strength of a given password based on various criteria.
	/// </summary>
	/// <param name="password">The password to evaluate.</param>
	/// <returns>The strength score of the password.</returns>
	public static int CalculateStrength(string password)
	{
		ValidatePassword(password);

		int lengthStrength     = CalculateLengthStrength(password);
		int complexityStrength = CalculateComplexityStrength(password);
		int repetitionScore    = CountRepetitions(password);
		int dictionaryScore    = CheckAgainstDictionary(password) ? -10 : 0;
		int totalScore = CalculateTotalScore(lengthStrength: lengthStrength, complexityStrength: complexityStrength,
			repetitionScore: repetitionScore,                                dictionaryScore: dictionaryScore);

		return CapTotalScore(totalScore);
	}

	private static void ValidatePasswordLength(int? length)
	{
		if (length is <= 0)
			throw new ArgumentException("Password length must be greater than zero.");
	}

	private static void ValidateCharacterTypes(bool includeUpper, bool includeLower, bool includeNumbers,
		bool                                        includeSpecial)
	{
		if (!(includeUpper || includeLower || includeNumbers || includeSpecial))
			throw new ArgumentException("Please select at least one character type for the password.");
	}

	private static void AppendCharacters(StringBuilder characters, bool include, string characterSet)
	{
		if (include) characters.Append(characterSet);
	}

	private static void ValidateCharacterSet(StringBuilder characters)
	{
		if (characters.Length == 0)
			throw new ArgumentException("Please select at least one character type for the password.");
	}

	private static void ValidatePassword(string password)
	{
		if (string.IsNullOrWhiteSpace(password))
			throw new ArgumentException("Password cannot be null, empty, or contain only whitespaces.");
	}

	private static int CalculateLengthStrength(string password)
	{
		return password.Length switch
		{
			< 30 and > 8 => password.Length,
			> 30         => 30,
			_            => 0
		};
	}

	private static int CalculateComplexityStrength(string password)
	{
		int complexityStrength = 0;
		if (ContainsCharacters(input: password, charSet: "abcdefghijklmnopqrstuvwxyz") &&
			ContainsCharacters(input: password, charSet: "ABCDEFGHIJKLMNOPQRSTUVWXYZ"))
			complexityStrength += 10;

		if (ContainsCharacters(input: password, charSet: "0123456789")) complexityStrength    += 20;
		if (ContainsCharacters(input: password, charSet: "!@#$%^&*()_ +")) complexityStrength += 20;

		return complexityStrength;
	}

	private static int CountRepetitions(string input)
	{
		int repetitionCount = 0;
		for (int i = 0; i < input.Length; i++)
		{
			if ((i + 1) < input.Length)
				if (input[i] == input[i + 1])
					repetitionCount--;

			if ((i + 2) >= input.Length) continue;
			if (input[i] == input[i + 2])
				repetitionCount -= 3;
		}

		return repetitionCount;
	}

	private static bool CheckAgainstDictionary(string input)
	{
		string[] commonWords;
		string   dictionaryPath = Path.Combine(path1: Environment.CurrentDirectory, path2: "Dictionary.txt");
		if (!File.Exists(dictionaryPath))
			commonWords = new[]
			{
				"password", "123456", "qwerty", "admin", "letmein", "welcome", "1234", "abc123", "password1",
				"12345", "admin123", "adminadmin", "pass123", "root", "test", "123", "user", "guest", "login",
				"changeme", "password123"
			};
		else
			commonWords = File.ReadAllLines("Dictionary.txt")
				.Select(line => line.Trim('"').ToLowerInvariant())
				.ToArray();

		string lowercaseInput = input.ToLower();

		return commonWords.Contains(lowercaseInput);
	}

	private static bool ContainsCharacters(string input, string charSet) => input.Any(charSet.Contains);

	private static int CalculateTotalScore(int lengthStrength, int complexityStrength, int repetitionScore,
		int dictionaryScore) => (lengthStrength * 2) + (complexityStrength * 2) + (repetitionScore * 4) +
		(dictionaryScore * 5);

	private static int CapTotalScore(int totalScore)
	{
		return totalScore switch
		{
			> 1000 => 1000,
			< 0    => 0,
			_      => totalScore
		};
	}
}