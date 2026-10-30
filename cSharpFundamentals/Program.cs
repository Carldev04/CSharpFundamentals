
using System;

namespace cSharpFundamentals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Variables.Main2(args);
            Comments.komentari(args);
            Constants._constants_(args);
            DisplayVariables._DisplayVariables_(args);
            MultipleVariables._MultipleVariables_(args);
            Identifiers.PrintIdentifiers(args);
            _03_Data_Types.DataTypes._DataTypes_(args);
            _04_Casting.DataCasting._DataCasting_(args);
            _05_UserInput.UserInput._UserInput_(args);
            _06_Operators.ArithmeticOperators._Operators_();
            _06_Operators.AssignmentOperators._AssignmentOperators_(args);
            _06_Operators.ComparisonOperators._ComparisonOperators_(args);
            _06_Operators.LogicalOperators._LogicalOperators_(args);
            _07_Math.MathExample._Math_(args);
            _08_StringExamples.typeOfString.Strings(args);
            _08_StringExamples.StringConcatenation.StringConcatenationExample();
            _08_StringExamples.StringInterpolation.StringInterpolationExample();
            _08_StringExamples.AccessStrings.AccessStringsExample(args);
            _08_StringExamples.SpecialCharacters.SpecialCharactersExample(args);
            _09_Booleans.Booleans.BooleansExample(args);
            _10_IfElse.ifstatement.ifstatementExample(args);
            _10_IfElse.ifElseStatement.ifElseStatementExample(args);
            _10_IfElse.ifElseIf.ifElseIfExample(args);
            _11_switch.switchName.SwitchExample(args);
            _12_whilepetlje.whilepetlje.WhilePetljaExample(args);
            _13_forpetlja.ForPetlja.ForPetljaExample(args);
            _13_forpetlja.ForeachLoop.ForeachLoop_Example();
            _14_break_continue.BreakContinue.BreakContinueExample(args);
            _15_Nizovi.Nizovi.NizoviExample(args);
            _15_Nizovi.LoopThroughArrays.LoopThroughArraysExample(args);
            _15_Nizovi.SortArrays.SortArrays_Example(args);
            _15_Nizovi.MultidimensionalArrays.MultidimensionalArraysExample(args);
            _16_Metode.Metode.MetodeExample(args);
            _16_Metode.Parameters.ParametersExample(args);
            _16_Metode.DefaultParameterValue.DefaultParameterValueExample();
            _16_Metode.ReturnValues.ReturnValuesExample(args);
            _16_Metode.NamedArguments.NamedArgumentsExample(args);
            _16_Metode.MethodOverloading.MethodOverloadingExample(args);
            _17_OOP.OOP.OOPExample(args);
            _18_ClassesAndObjects.ClassesAndObjects.ClassesAndObjectsExample(args);
            _18_ClassesAndObjects.MultipleClassesAndObjects.MultipleClassesAndObjectsExample(args);
            _18_ClassesAndObjects.prog2.prog2Example(args);
            _18_ClassesAndObjects.prog.progExample(args);
            _19_ClassMembers.ClassMembers.ClassMembersExample(args);
            _19_ClassMembers.prog2.prog2Example(args);
            _20_Constructors.Constructors_1.ConstructorsExample(args);
            _20_Constructors.Constructors_2.Constructors_2Example(args);
            _20_Constructors.ConstructorsDemo.prog2Example(args);
            _21_AccessModifiers.AccessModifiers.AccessModifiersExample(args);
            _21_AccessModifiers.PrivateModifier.PrivateModifierExample(args); //Ovo ako ne napravim konzola nece ispisati kod.
            _22_Properties.Properties.PropertiesExample(args);
            _22_Properties.AutomaticProperties_ShortHand.AutomaticProperties_ShortHandExample(args);
            _23_inheritance.Inheritance.InheritanceExample(args);
            _24_Polymorphism.Polymorphism.PolymorphismExample(args);
        }
    }
}