using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoller;

/// <summary>
/// Highlighting then pressing shift+tab will remove the indentation
/// </summary>

/// <summary>
/// This represents a configurable die used in games or simulations
/// </summary>

public class Die
{
    /// <exception cref="ArgumentOutOfRangeException"> Thrown when invalid number of sides is provided</exception>
    public Die(byte numSides)
    {
        if (numSides == 0 || numSides > 20)
        {
            throw new ArgumentOutOfRangeException(nameof(numSides), 
                $"{nameof(numSides)} must be greater than 0 and less than 21");
        }
        NumberOfSides = numSides;
    }

    /// <summary>
    /// Gets the number of sides for the die
    /// </summary>
    public byte NumberOfSides { get; private set; }

    /// <summary>
    /// Current face value for the die
    /// </summary>
    public byte DieFaceValue { get; private set; }

    /// <summary>
    /// Simulates rolling the die and returns what number the die landed on
    /// </summary>
    /// <returns>A byte representative of the value the die landed on</returns>
    public byte Roll()
    {
        Random rand = new();
        DieFaceValue = Convert.ToByte(rand.Next(1, NumberOfSides + 1));

        return DieFaceValue;
    }
}
