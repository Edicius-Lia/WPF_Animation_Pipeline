# Animation_Demo

## 项目简介
这是一个基于 WPF  的动画演示项目，主要展示如何使用 Storyboard 和 Polyline 控件实现管道流动虚线动画效果。

## 功能说明
- 利用 Storyboard 和 DoubleAnimation 控制 Polyline 的 StrokeDashOffset，实现虚线流动动画。
- 支持动画的启动与关闭。
- 动画可无限循环播放。

## 主要组件
- `MainWindow.xaml`：主窗口界面，包含动画相关控件和按钮。
- `MainWindow.xaml.cs`：主窗口逻辑，负责动画的初始化、启动与关闭。
- `AnimationPipelineItem`：动画管道类，封装动画控件和管道对象。

## 使用方法
1. 启动程序后，点击“启动动画”按钮（Btn_switch），管道虚线动画开始流动。
2. 点击“关闭动画”按钮（Btn_close），动画停止并隐藏管道。

## 依赖环境
- C# 7.3
- .NET Framework 4.7.2
- WPF

## 代码结构简要
- `Btn_switch_Click`：启动动画，设置虚线样式并开始 Storyboard。
- `Btn_close_Click`：关闭动画，隐藏管道并停止 Storyboard。
- `AnimationPipelineItem`：管理动画 Storyboard 和 Polyline 控件。

## 运行截图
<img width="775" height="437" alt="image" src="https://github.com/user-attachments/assets/74d7bb2b-579a-4567-ab74-605d93338e5a" />


## 许可证
本项目仅用于学习和演示用途。
