   M S B A M L   `   `   `  ����C  ?MVVMDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MVVMDemoMVVMDemo  5   	   9!clr-namespace:MVVMDemo.ViewModelsMVVMDemo.ViewModels  5   	       MVVMDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:MVVMDemo     5   	   0vm!clr-namespace:MVVMDemo.ViewModels     5   	     � Title$  
MainWindow��5	   	   $	��350��6   $	��525��6)    � 	Resources 5
      -   'MVVMDemo.ViewModels.MainWindowViewModel   EmployeeViewModel��%   &	          5   
   6!   5      .��5      �  � DataContext 6   ��  �� Source# [   � RowDefinitions 5   
   �� 5      $��40 �6   6*   �� 5      6   �� 5      $��40 �6   6*   .+�5   
   �� $��0��6   $��Center=�6   $��Center=�6:   $ ��CURD Operaion through MVVM��6U   6|   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $��* �6#   6/   �� 5      $��* �6#   6/   .+�5      �� $��0��6    �� Orientation$ Vertical=�6&   .+�5      �� $ 
Horizontal=�6   $��	10 10 0 0q�66   .+�5      �� $��50��6   $
��Name��6'   69   �� 5      -   5         ��Name$ txtName��5      $	��180��6/   ��6;   ��  �� Path$ CurrentEmployee.Name�	 �� Mode$	 TwoWay=�

 � Tag
 6s   �� $ CurrentEmployee.Id�$	 TwoWay=�5      �� 5      $ 
Horizontal=�6   $��	10 10 0 0q�66   .+�5      �� $��50��6   $��Address��6'   6;   �� 5       -   5        $ 
txtAddress��5       $	��180��62   ��6?   �� $ CurrentEmployee.Address�$	 TwoWay=�5!      �� 5"      $ 
Horizontal=�6   $��	10 10 0 0q�66   .+�5#      �� $��50��6   $
��City��6'   68   �� 5$      -   5        $ txtCity��5$      $	��180��6/   ��6<   �� $ CurrentEmployee.City�$	 TwoWay=�5%      �� 5&      $ 
Horizontal=�6   $��	10 10 0 0q�66   .+�5'      �� $��50��6   $��Salary��6'   6:   �� 5(      -   5        $ 	txtSalary��5(      $	��180��61   ��6=   �� $ CurrentEmployee.Salary�$	 TwoWay=�5)      5*      &   System.Windows.Controls.DataGrid  5+      -   5          Name$ DataGridShow��5+      $��1��6-      AutoGenerateColumns .  ��6Y   �� $ employeesList�$	 TwoWay=� J� InputBindings 5,      d� 5-       d� Gesture$ LeftDoubleClicka�6#    �� Command 6=   �� *Mycmd+ �� CommandParameter 6W   ��  �� ElementName$ DataGridShow��$ SelectedItem�   Columns 5/      0  *System.Windows.Controls.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6)      
Visibility$ 	Collapsed=�6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� $ Id�6Q     51      $
 Name��6)      
IsReadOnly .  67   �� $
 Name�6V     52      $ Address��6)    .  6:   �� $ Address�6[     53      $
 City��6)    .  67   �� $
 City�6U     54      $ Salary��6)    .  69   �� $ Salary�6Y   56      57      �� 58   
   $��2��6   $ 
Horizontal=�6"   $��Center=�6;   .+�59      �� -   5         ��Name$ 	btnInsert��59      $��Insert��6(   $��0 2 0 2q�69   $��	20 0 20 0q�6J   $	��Add��6x   ��6^   �� *Mycmd+6x   �� 5:      -   5        $ 	btnUpdate��5:      $��Update��6(   $��10 2 0 2q�69   $��	20 0 20 0q�6K   $
��Edit��6y   ��6_   �� *Mycmd+6y   �� 5;      -   5        $ 	btnDelete��5;      $��Delete��6(   $��10 2 0 2q�69   $��	20 0 20 0q�6K   $��Remove��6y   ��6_   �� *Mycmd+6y   �� 5<      -	   5        $ btnClear��5<      $��Clear��6'   $��10 2 0 2q�67   $��	20 0 20 0q�6I   $��Clear��6w   ��6]   �� *Mycmd+6w   5=      5>      5?      