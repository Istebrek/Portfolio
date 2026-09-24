using System.ComponentModel;
using System.Reflection;
using Shared.Lists;

namespace UI.Extensions;

public static class DisplayExtension
{
    public static string SkillDisplay(this Skill skill)
    {
        var field = skill.GetType().GetField(skill.ToString());
        var attr = field?.GetCustomAttribute<DescriptionAttribute>();

        return attr?.Description ?? skill.ToString();
    }

    //use: in blazor when iterating over skills: var skill in skills @skill.SkillDisplay()
}