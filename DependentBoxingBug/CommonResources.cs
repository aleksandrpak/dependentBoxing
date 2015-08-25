using System.Windows;
using System.Windows.Media;

namespace DependentBoxingBug
{
    public class CommonResources
    {
        public static readonly CommonResources Instance = new CommonResources();

        private CommonResources()
        {
            CellHorizontalAlignment = HorizontalAlignment.Left;
            CellVerticalAlignment = VerticalAlignment.Center;
            CellHeight = 19;
            CellBackground = new SolidColorBrush(Colors.Transparent);
            CellBorder = new SolidColorBrush(Colors.Transparent);
            ElementBackground = new SolidColorBrush(Colors.DarkGray);
            MouseOverBorderBackground = new SolidColorBrush(Colors.LightGray);
            SelectedBorderBackground = new SolidColorBrush(Colors.Gray);
        }

        public SolidColorBrush ElementBackground { get; set; }
        public SolidColorBrush MouseOverBorderBackground { get; set; }
        public SolidColorBrush SelectedBorderBackground { get; set; }
        public float CellHeight { get; set; }
        public HorizontalAlignment CellHorizontalAlignment { get; set; }
        public VerticalAlignment CellVerticalAlignment { get; set; }
        public SolidColorBrush CellBackground { get; set; }
        public SolidColorBrush CellBorder { get; set; }
    }
}