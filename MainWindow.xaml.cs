using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Animation_Demo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        AnimationPipelineItem animationPipelineItem = new AnimationPipelineItem();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            animationPipelineItem.polyline = myPolyine;
            animationPipelineItem.polyline.Visibility = Visibility.Collapsed;
        }

        
        private void Btn_switch_Click(object sender, RoutedEventArgs e)
        {
            animationPipelineItem.polyline.Visibility = Visibility.Visible;
            animationPipelineItem.polyline.StrokeDashArray = new DoubleCollection(new Double[] { 5, 5 });//虚线的实线和虚线长度集合
            Storyboard storyboard = new Storyboard
            {
                RepeatBehavior = RepeatBehavior.Forever//动画重复执行方式
            };
            DoubleAnimation doubleAnimation = new DoubleAnimation
            {
                From = 20,
                To = 0,
                Duration = TimeSpan.FromSeconds(5),//动画执行时间,越小越快
                AutoReverse = false
            };
            Storyboard.SetTarget(doubleAnimation, animationPipelineItem.polyline);
            Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("StrokeDashOffset"));//动画主要控制虚线的偏移量来实现流动效果
            storyboard.Children.Add(doubleAnimation);
            animationPipelineItem.storyboard = storyboard;
            animationPipelineItem.storyboard.Begin();
        }

        private void Btn_close_Click(object sender, RoutedEventArgs e)
        {
            animationPipelineItem.polyline.Visibility = Visibility.Collapsed;
            animationPipelineItem.storyboard?.Stop();
        }
    }
    /// <summary>
    /// 管道动画
    /// </summary>
    internal class AnimationPipelineItem
    {
        /// <summary>
        /// 动画控件
        /// </summary>
        public Storyboard storyboard = null;

        /// <summary>
        /// 管道
        /// </summary>
        public Polyline polyline = null;

    }
}
