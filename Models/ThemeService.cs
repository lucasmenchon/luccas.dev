namespace BlazorWebProfile.Models
{
    public class ThemeService
    {
        public bool DarkMode { get; set; }

        public event Action<bool>? OnThemeChanged;

        public ThemeService()
        {
            DarkMode = true;
        }

        public bool ToggleTheme()
        {
            DarkMode = !DarkMode;
            OnThemeChanged?.Invoke(DarkMode);
            return DarkMode;
        }
    }
}
