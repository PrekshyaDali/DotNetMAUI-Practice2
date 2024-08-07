using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveChartsCore.SkiaSharpView.VisualElements;

namespace PrekshyaMaui.ViewModels
{
    public class CustomGraphViewModel
    {
        public ISeries[] Series { get; set; } =
    {
        new ColumnSeries<double>
        {
            Name = "Mary",
            Values = new double[] { 2, 5, 4 },
            DataLabelsPaint = new SolidColorPaint(SKColors.Black),
            DataLabelsSize = 18
        },
        new ColumnSeries<double>
        {
            Name = "Ana",
            Values = new double[] { 3, 1, 6 },
            DataLabelsPaint = new SolidColorPaint(SKColors.Black), 
            DataLabelsSize = 18
        }
    };

        public Axis[] XAxes { get; set; } =
        {
        new Axis
        {
            Name = "Categories", 
            Labels = new string[] { "Category 1", "Category 2", "Category 3" },
            LabelsRotation = 15, 
            SeparatorsPaint = new SolidColorPaint(new SKColor(200, 200, 200)),
            TicksPaint = new SolidColorPaint(new SKColor(35, 35, 35)),
            NamePaint = new SolidColorPaint(SKColors.Blue), 
            Labeler = value => "Label " + value 
        }
    };

        public Axis[] YAxes { get; set; } =
        {
        new Axis
        {
            // Customize axis title paint
            NamePaint = new SolidColorPaint(SKColors.Blue), 
            // Custom label formatter
            Labeler = value => value.ToString("N") 
        }
    };

        public LabelVisual Title { get; set; } =
          new LabelVisual
          {
              Text = "My custom title",
              TextSize = 25,
              Padding = new LiveChartsCore.Drawing.Padding(15),
              Paint = new SolidColorPaint(SKColors.DarkSlateGray)
          };
    }
}
