﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34014
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("monploy.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Board() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Board", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Position,SlotName,Colour, Type, Cost, Cost_House, Rent, RentWith1House,RentWith2House,RentWith3House,RentWith5House,RentWithHotel
        '''0, &quot;Go&quot;, &quot;Green&quot;, Go, 0,0,200,0,0,0,0,0
        '''1, &quot;mayfair&quot;, &quot;BLUE&quot;, &quot;Standard&quot;, 100.
        '''</summary>
        Friend ReadOnly Property BoardPlaces() As String
            Get
                Return ResourceManager.GetString("BoardPlaces", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 0,Go,NILL,GO,NILL,NILL,-200,NILL,NILL,NILL,NILL,NILL
        '''1,Old Kent Road,Brown,STANDARD,60,120,6,40,80,160,240,1000
        '''2,Chest,NILL,CHEST,NILL,NILL,NILL,NILL,NILL,NILL,NILL,NILL
        '''3,White Chapel,Brown,STANDARD,60,120,6,40,80,160,240,1000
        '''4,Income tax,NILL,TAX,NILL,NILL,200,NILL,NILL,NILL,NILL,NILL
        '''5,King&apos;s Cross station,Station,STATION,200,NILL,25,50,100,200,NILL,NILL
        '''6,The Angel Iliston,Light_Blue,STANDARD,100,120,140,160,180,200,240,300
        '''7,Chance,Chance,CHANCE,NILL,NILL,NILL,NILL,NILL,NILL,NILL,NILL
        '''8,Eusto [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property BoardPlacesnew() As String
            Get
                Return ResourceManager.GetString("BoardPlacesnew", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property CC() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("CC", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Chance() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Chance", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property DiceFive() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("DiceFive", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property DiceFour() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("DiceFour", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property DiceSix() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("DiceSix", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property DiceThree() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("DiceThree", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property DiceTwo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("DiceTwo", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
