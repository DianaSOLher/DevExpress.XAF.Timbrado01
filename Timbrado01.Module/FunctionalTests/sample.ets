;#DropDB Timbrado01EasyTest

#Application Timbrado01Win
;#Application Timbrado01Web

*FillForm
 User Name = Admin
*Action Log In

#IfDef Timbrado01Win

*Action About...
 
*Action OK

#EndIf

#IfDef Timbrado01Web
*Action Navigation(My Details)
#EndIf
