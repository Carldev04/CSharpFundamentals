
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
        }
    }
}