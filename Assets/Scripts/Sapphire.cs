using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sapphire : Gems //INHERITANCE
{
    public override string Name { get => "sapphire"; } //POLYMORPHISM
    public override Color Color => Color.blue; //POLYMORPHISM
    public override int Hardness => 9; //POLYMORPHISM
}
