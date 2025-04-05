namespace Vektorel.GameCenter.Enums;

[Flags]
public enum Kind : int
{
    NotSet = 0,
    Adventure = 1,
    Survivor = 2,
    Strategy = 4,
    Racing = 8,
    Online = 16,
    Mobile = 32,
    Single = 64
}
