using System;

class Money
{
    private int _gold;
    private int _silver;

    public int Gold
    {
        get
        {
            if (_gold < 0) _gold = 0;
            return _gold;
        }
    }

    public int Silver
    {
        get
        {
            if (_silver < 0) _silver = 0;
            return _silver;
        }
    }

    public Money(int gold, int silver)
    {
        _gold = gold;
        _silver = silver;
    }

    public Money Add(int gold, int silver) => new Money(Gold + gold, Silver + silver);

    public Money Subtract(int gold, int silver) => new Money(Gold - gold, Silver - silver);

    public override string ToString() => $"{Gold}골드 {Silver}실버";
}