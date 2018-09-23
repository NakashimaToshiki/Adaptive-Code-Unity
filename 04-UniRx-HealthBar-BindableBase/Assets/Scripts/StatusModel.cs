using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusModel : BindableBase
{
    [SerializeField]
    private int healthMax;
    public int HealthMax
    {
        get { return healthMax; }
        set { this.SetProperty(ref this.healthMax, value); }
    }

    [SerializeField]
    private int health;
    public int Health
    {
        get { return health; }
        set { this.SetProperty(ref this.health, value); }
    }
}
