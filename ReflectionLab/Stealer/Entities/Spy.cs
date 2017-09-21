using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string calssName, params string[] fields)
    {
        StringBuilder result = new StringBuilder();

        Type typeOfClass = Type.GetType(calssName);

        FieldInfo[] fieldsInfo = typeOfClass.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance |
            BindingFlags.NonPublic);

        Object instance = Activator.CreateInstance(typeOfClass);

        result.AppendLine($"Class under investigation: {calssName}");
        foreach (FieldInfo fieldInfo in fieldsInfo.Where(f => fields.Contains(f.Name)))
        {
            result.AppendLine($"{fieldInfo.Name} = {fieldInfo.GetValue(instance)}");
        }

        return result.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string className)
    {
        StringBuilder result = new StringBuilder();

        Type hackerClass = Type.GetType(className);

        FieldInfo[] fields = hackerClass.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
        MethodInfo[] publicMethods = hackerClass.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        MethodInfo[] nonPublicMethods = hackerClass.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        foreach (var field in fields)
        {
            result.AppendLine($"{field.Name} must be private!");
        }

        foreach (MethodInfo method in nonPublicMethods.Where(p => p.Name.StartsWith("get")))
        {
            result.AppendLine($"{method.Name} have to be public!");
        }

        foreach (MethodInfo method in publicMethods.Where(p => p.Name.StartsWith("set")))
        {
            result.AppendLine($"{method.Name} have to be private!");
        }

        return result.ToString().Trim();
    }

    public string RevealPrivateMethods(string className)
    {
        StringBuilder result = new StringBuilder();

        Type hackerType = Type.GetType(className);
        MethodInfo[] privateMethods =
            hackerType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        result.AppendLine($"All Private Methods of Class: {className}");
        result.AppendLine($"Base Class: {hackerType.BaseType.Name}");

        foreach (MethodInfo method in privateMethods)
        {
            result.AppendLine(method.Name);
        }

        return result.ToString().Trim();
    }

    public string CollectGettersAndSetters(string className)
    {
        StringBuilder result = new StringBuilder();

        Type hackerType = Type.GetType(className);
        MethodInfo[] methods = hackerType.GetMethods(
            BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

        foreach (MethodInfo method in methods.Where(m => m.Name.StartsWith("get")))
        {
            result.AppendLine($"{method.Name} will return {method.ReturnType}");
        }

        foreach (MethodInfo method in methods.Where(m => m.Name.StartsWith("set")))
        {
            result.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
        }

        return result.ToString().Trim();
    }
}