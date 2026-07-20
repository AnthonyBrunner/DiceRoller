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
}
