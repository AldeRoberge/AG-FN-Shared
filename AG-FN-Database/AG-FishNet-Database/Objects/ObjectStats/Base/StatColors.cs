using OpenAlienGarden.Core.Identities;

namespace OpenAlienGarden.ObjectStats.Base
{
    public static class StatColors
    {
        // Primary colors
        public static readonly StatColor Red   = new StatColor(0, nameof(Red));
        public static readonly StatColor Green = new StatColor(1, nameof(Green));
        public static readonly StatColor Blue  = new StatColor(2, nameof(Blue));

        // Compound (additive colors)
        public static readonly CompoundStatColor Yellow  = new CompoundStatColor(3, nameof(Yellow), new[] {Red, Green});
        public static readonly CompoundStatColor Cyan    = new CompoundStatColor(4, nameof(Cyan), new[] {Green, Blue});
        public static readonly CompoundStatColor Magenta = new CompoundStatColor(5, nameof(Magenta), new[] {Blue, Red});

        // White (all colors)
        public static readonly CompoundStatColor White = new CompoundStatColor(6, nameof(White), new[] {Red, Green, Blue});

        public static readonly StatColor[] RedColors   = {Red, Yellow, Magenta, White};
        public static readonly StatColor[] GreenColors = {Green, Cyan, Yellow, White};
        public static readonly StatColor[] BlueColors  = {Blue, Cyan, Magenta, White};
    }
    
    /**
     * The three main colors.
     * Red, Green and Blue.
     */
    public class StatColor : Identity
    {
        public StatColor(int id, string name) : base(name)
        {
        }
    }

    /**
     * Colors that are mixes of two (or three) other colors.
     * Yellow, Cyan, purple and White.
     */
    public class CompoundStatColor : StatColor
    {
        // The colors that make up this compound color.
        public StatColor[] Colors;

        public CompoundStatColor(int id, string name, StatColor[] colors) : base(id, name)
        {
            Colors = colors;
        }
    }
}