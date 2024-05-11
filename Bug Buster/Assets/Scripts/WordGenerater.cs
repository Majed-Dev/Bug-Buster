using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class WordGenerater : MonoBehaviour
{
    public static WordGenerater Instance;
    private string pythonFilePath = Application.dataPath + "/Assets/Python Keywrods.txt";
    private static string[] PythonWordList = {"False", "None", "True", "and", "as", "assert", "async", "await", "break", "class",
                                              "continue", "def", "del", "elif", "else", "except", "finally", "for", "from", "global",
                                              "if", "import", "in", "is", "lambda", "nonlocal", "not", "or", "pass", "raise", "return",
                                               "try", "while", "with", "yield" };
    //-------------------------------------------------------------------------------------------------------------------------------------------------------------
    private static string[] JavaWordList = {
            "abstract", "assert", "boolean", "break", "byte", "case", "catch", "char",
            "class", "continue", "default", "do", "double", "else", "enum", "extends",
            "final", "finally", "float", "for", "if", "implements", "import", "instanceof",
            "int", "interface", "long", "native", "new", "package", "private", "protected",
            "public", "return", "short", "static", "strictfp", "super", "switch", "synchronized",
            "this", "throw", "throws", "transient", "try", "void", "volatile", "while"
                                           };
    //-------------------------------------------------------------------------------------------------------------------------------------------------------------
    private static string[] CPPWordList = {"alignas", "alignof", "and", "asm",
                                            "auto", "bitand", "bitor", "bool", "break", "case", "catch",
                                            "char", "class", "compl", "concept", "const",
                                            "consteval", "constexpr", "constinit","continue",
                                             "decltype", "default", "delete", "do", "double",
                                             "else", "enum", "explicit", "export", "extern", "false", "float", "for", "friend", "goto",
                                                "if", "inline", "int", "long", "mutable", "namespace", "new", "noexcept", "not",
                                                "nullptr", "operator", "or", "private", "protected", "public", "reflexpr", "register",
                                                 "requires", "return", "short", "signed", "sizeof", "static",
                                                 "struct", "switch", "synchronized", "template", "this", "throw",
                                                "true", "try", "typedef", "typeid", "typename", "union", "unsigned", "using", "virtual", "void",
                                                "volatile", "while", "xor" };
    //-------------------------------------------------------------------------------------------------------------------------------------------------------------
    private static string[] CsharpWordList = {
            "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked",
            "class", "const", "continue", "decimal", "default", "delegate", "do", "double", "else",
            "enum", "event", "explicit", "extern", "false", "finally", "fixed", "float", "for",
            "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal", "is", "lock",
            "long", "namespace", "new", "null", "object", "operator", "out", "override", "params",
            "private", "protected", "public", "readonly", "ref", "return", "sbyte", "sealed",
            "short", "sizeof", "stackalloc", "static", "string", "struct", "switch", "this",
            "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort",
            "using", "var", "virtual", "void", "volatile", "while", "yield"
        };
    //-------------------------------------------------------------------------------------------------------------------------------------------------------------

    //index to switch between languages
    public static int languageIndex = 1;
    public static string[] wordList;
    void Start()
    {
        Instance = this;
    }
    public static string GetRandomWord()
    {
        switch (languageIndex)
        {
            case 0: wordList = PythonWordList; break;
            case 1: wordList = JavaWordList; break;
            case 2: wordList = CPPWordList; break;
            case 3: wordList = CsharpWordList; break;
            default: wordList = JavaWordList; break;
            
        }
       int randomIndex = Random.Range(0,wordList.Length);
        return wordList[randomIndex];
    }
}
