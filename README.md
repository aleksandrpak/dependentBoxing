# Description

This is test project for reproducing bug https://connect.microsoft.com/VisualStudio/feedback/details/1691490/boxing-of-system-windows-dependent-in-frugallist-t

A big amout of System.Windows.Dependent is boxed because of styles. I have made example as simple as possible so somethings are not done as in real life application.

To reproduce issue please start application and start typing anything to the TextBox on the top. It will filter items and will lead to reapplying of styles to many different DataGridCells. One of the issue with this is a lot of System.Windows.Dependent boxing.

Here you can see screenshot from DotMemory MemoryTraffic view:
![Memory Traffic](MemoryTrafficScreenshot.png)

Also if you have DotMemory application you can view result of profiling in this workspace: https://dl.dropboxusercontent.com/u/67551504/DependentBoxingBug%20%5B2015-08-25%5D%20%5B10-56%5D.dmw
