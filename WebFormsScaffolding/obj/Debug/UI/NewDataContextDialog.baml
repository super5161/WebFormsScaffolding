   M S B A M L   `   `   `  ����`  \Microsoft.AspNet.Scaffolding.WebForms, Version=0.1.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:Microsoft.AspNet.Scaffolding.VSExtension.UI+Microsoft.AspNet.Scaffolding.VSExtension.UI  5      c6clr-namespace:Microsoft.AspNet.Scaffolding.WebForms.UI(Microsoft.AspNet.Scaffolding.WebForms.UI  5      C   =Microsoft.AspNet.Scaffolding.WebForms.UI.NewDataContextDialog   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Hui9clr-namespace:Microsoft.AspNet.Scaffolding.VSExtension.UI     5      Gself6clr-namespace:Microsoft.AspNet.Scaffolding.WebForms.UI     5      L   FMicrosoft.AspNet.Scaffolding.WebForms.UI.NewDataContextDialogResources    Title � Title# Z  5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterOwner=�5	      $	��146��5
      $	��596��5      <  6Microsoft.AspNet.Scaffolding.WebForms.UI.FocusBehavior   FocusOnFirstElement .  � 	Resources 5       �� 
TargetType �� Triggers P� Property	 P� Value
 �� Property �� Value �� RelativeSource �� Path��%�   '��       �� 5   
   " ��6    5      P� 5       �@=�HasError	 . . �5      �� 
 �@�ToolTip 60   ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent�5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �� "   NewDataContextLabel_Content#��Z 6   $
��Left=�5      $��	12,12,0,0q�5      $	��Top=�5       �� Target 5       ��  �� ElementName$ dataContextTextBox���� 5!   
   -   5        $��dataContextTextBox��5!      $��Stretch=�5"      $��23��5#      $��
12,38,12,0q�5$       �� TextWrapping$
 Wrap=�5%      $	��Top=�5'      $��Center=�5(       �� TextProperty;  5Microsoft.AspNet.Scaffolding.WebForms.UI.BindBehavior   ForceBindOnEnter# Z 5)      ��5&      �� *DbContextTypeName+5)      �� 5*   
      OkButton_Content#��Z 6   $
��Left=�5+      $��
410,0,0,10q�5,       �� 	IsDefault . $��Bottom=�5.      $��75��5/      $��23��50      $��1��52      ��51      �� *	OkCommand+52      �� 53   
      CancelButton_Content#��Z 6   $
��Left=�54      $��
495,0,0,10q�55      $��Bottom=�56      $��75��57      $��23��58       �� IsCancel . $��1��5:      5;      5<      