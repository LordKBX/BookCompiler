using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace BookCompiler
{
    public class Theme
    {
        public Color BackgroundColor { get; set; } = Color.White;
        public Color ForegroundColor { get; set; } = Color.Black;
        public Color BorderColor { get; set; } = Color.Black;
        public Color ButtonBackgroundColor { get; set; } = Color.White;
        public Color ButtonForegroundColor { get; set; } = Color.Black;
        public Color InputBackgroundColor { get; set; } = Color.White;
        public Color InputForegroundColor { get; set; } = Color.Black;
    }

    public static class Themes
    {
        private static Dictionary<string, Theme> _themes = new Dictionary<string, Theme>() {
            { 
                "clear", 
                new Theme(){ 
                    BackgroundColor = Color.White,
                    ForegroundColor = Color.Black,
                    BorderColor = Color.Black,
                    ButtonBackgroundColor = Color.FromArgb(255, 204, 204, 204),
                    ButtonForegroundColor = Color.Black,
                    InputBackgroundColor = Color.White,
                    InputForegroundColor = Color.Black,
                } 
            },
            { 
                "black", 
                new Theme(){ 
                    BackgroundColor = Color.FromArgb(255, 73, 73, 73),
                    ForegroundColor = Color.White,
                    BorderColor = Color.White,
                    ButtonBackgroundColor = Color.FromArgb(255, 51, 51, 51),
                    ButtonForegroundColor = Color.White,
                    InputBackgroundColor = Color.FromArgb(255, 153, 153, 153),
                    InputForegroundColor = Color.White,
                } 
            }
        };

        public static Theme? getTheme(string name) {
            if (_themes.ContainsKey(name)) { return _themes[name]; }
            else { return null; }
        }
    }
}
