   M S B A M L   `   `   `  ???? G  CGraphDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:GraphDesktop.UserContolsGraphDesktop.UserContols  *    $GraphDesktop.UserContols.GraphCanvas   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     8local&clr-namespace:GraphDesktop.UserContols     $
??Auto??$
??Auto??|?.   ? DataContext  ??  ?? RelativeSource ?? *Self+ ? 	Resources  ?? 
TargetType ?? Property   Formular ?? Value??%n  '??       7   '?? M     7   '?? ?     7   '?? ?     7   ?? " ??.???  ? ??8   ??  ? ??$ 14(???  ? ??$
 Bold"??? " ??.???  ? ??8   ??  ? ??$ 14(???  ? ??$ Medium"??? " ??.???  ? ??8   ??  ? ??$ 14(???  ? ??$
 Bold"??? " ??.???  ? ??8   ??  ? ??$ 14(???  ? ??$
 Bold"? J? InputBindings ??  ?? 	Modifiers$	 Altf?
 ?? Key$ H??	 ?? Command	 ?? *ShowAdjgrid+.??? .+??? -   
 ??Name$
 Canvas??
?????? $
??Auto??$
??Auto??}?. .+?? -    ?Name$ Popup?? ? 	StaysOpen .  |?. $??
MousePoint=? ? PlacementTarget ??  ?? ElementName$ Canvas??.???? 
???????$??2,2,2,2q?._??? ???#F9F9F9$	??250??$??Stretch=?.+??? $??Center=????? *
Model.Name+ ?? Mode$ TwoWay=??  ? RowDefinitions ?? ?? ?? ?? .+?A? $??Center=? A? Columns$ 2??.+???  ?? TextAlignment$ Center=?$??Medium"?$??Матрица???? -    ??Name$ MatrixChoice??$??20??$	??140??$??Center=? ?? SelectedIndex$ 0??.@??? Инцидентности?? Смежности&   System.Windows.Controls.DataGrid  -     Name$ 
MatrixGrid??$??1??   AutoGenerateColumns .    
IsReadOnly . $	??250??$
??Auto??   HeadersVisibility$	 All=?   CanUserAddRows .     CanUserDeleteRows .  ???? *Matrix+9? $??2??.??A? $ 2??.+??? $??Диаметр :???? -    ??Name$ DiametrData???? $??Радиус???? -   $ 
RadiusData??? $??Stretch=?$??10,50,10,10q? ? ColumnDefinitions ?? ?? .+??? -   ???#525252$??50??$??0,0,10,0q????? " ??.???  ? ?? ??  ?? 
TargetType" ??.R???  ??Name$ Border??#??z??._??? $??Center=?$??Center=?$ Center=? ??%/   '??       ?? " ??.???  ? ??$
 Wrap=? ?? Triggers P?   P? Property  ?@J?IsMouseOver! P? Value! . . ??? " ?? 
TargetName$" Border?? ? ?? ?#757575???? $??11(?$??Medium"?$ Center=????#FFFFFF$*??$Добавить      вершину??$
??Wrap=? ??%9   '??       ?? " ??.???  ?@??CornerRadius$ 5???? -   $??10,0,0,0q?$??1?????#525252???? " ??.???  ? ?? ?? " ??.R??? $ Border??#??z??._??? $??Center=?$??Center=?$ Center=? ??%/   '??       ?? " ??.???  ? ??$
 Wrap=? P?   ?@J?IsMouseOver! . . ??? $" Border?? ? ?? ?#757575 ??%:   '??       ?? " ??.???  ?@??CornerRadius$ 10?????? $ Center=?$??Medium"?$??11(????#FFFFFF$,??&Очистить              граф??$
??Wrap=?  -	   $ MatrixAdjGrid?? . $??Right=?$??Bottom=? .   .  $	??250??$
??Auto??$	 All=????? *
AdjMatix+