﻿namespace Gu.Wpf.FlipView.Tests
{
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InkCanvas_OnGesture(object sender, InkCanvasGestureEventArgs e)
        {
            var recognitionResults = e.GetGestureRecognitionResults();
            this.ArgsBox.Items.Insert(0, string.Format("recieved gesture: {0}", recognitionResults.Count));

            foreach (var gestureRecognitionResult in recognitionResults)
            {
                string gesture = string.Format("{0} confidence: {1}", gestureRecognitionResult.ApplicationGesture, gestureRecognitionResult.RecognitionConfidence);
                this.ArgsBox.Items.Insert(0, gesture);
            }
        }
        private void OnClear(object sender, RoutedEventArgs e)
        {
            this.ArgsBox.Items.Clear();
        }
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.ArgsBox.Items.Insert(0, "Click");
        }
    }
}
