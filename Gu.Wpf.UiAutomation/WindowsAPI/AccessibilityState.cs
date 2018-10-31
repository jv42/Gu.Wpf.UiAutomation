// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable IdentifierTypo
#pragma warning disable SA1310 // Field names must not contain underscore
#pragma warning disable SA1600 // Elements must be documented
#pragma warning disable GU0060 // Enum member value conflict.
#pragma warning disable CA1707 // Identifiers should not contain underscores
namespace Gu.Wpf.UiAutomation.WindowsAPI
{
    using System;

    [Flags]
    public enum AccessibilityState : uint
    {
        STATE_SYSTEM_UNAVAILABLE = 0x00000001,
        STATE_SYSTEM_SELECTED = 0x00000002,
        STATE_SYSTEM_FOCUSED = 0x00000004,
        STATE_SYSTEM_PRESSED = 0x00000008,
        STATE_SYSTEM_CHECKED = 0x00000010,
        STATE_SYSTEM_MIXED = 0x00000020,
        STATE_SYSTEM_READONLY = 0x00000040,
        STATE_SYSTEM_HOTTRACKED = 0x00000080,
        STATE_SYSTEM_DEFAULT = 0x00000100,
        STATE_SYSTEM_EXPANDED = 0x00000200,
        STATE_SYSTEM_COLLAPSED = 0x00000400,
        STATE_SYSTEM_BUSY = 0x00000800,
        STATE_SYSTEM_FLOATING = 0x00001000,
        STATE_SYSTEM_MARQUEED = 0x00002000,
        STATE_SYSTEM_ANIMATED = 0x00004000,
        STATE_SYSTEM_INVISIBLE = 0x00008000,
        STATE_SYSTEM_OFFSCREEN = 0x00010000,
        STATE_SYSTEM_SIZEABLE = 0x00020000,
        STATE_SYSTEM_MOVEABLE = 0x00040000,
        STATE_SYSTEM_SELFVOICING = 0x00080000,
        STATE_SYSTEM_FOCUSABLE = 0x00100000,
        STATE_SYSTEM_SELECTABLE = 0x00200000,
        STATE_SYSTEM_LINKED = 0x00400000,
        STATE_SYSTEM_TRAVERSED = 0x00800000,
        STATE_SYSTEM_MULTISELECTABLE = 0x01000000,
        STATE_SYSTEM_EXTSELECTABLE = 0x02000000,
        STATE_SYSTEM_ALERT_LOW = 0x04000000,
        STATE_SYSTEM_ALERT_MEDIUM = 0x08000000,
        STATE_SYSTEM_ALERT_HIGH = 0x10000000,
        STATE_SYSTEM_VALID = 0x1FFFFFFF,
    }
}
