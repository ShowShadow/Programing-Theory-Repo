using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruby : Gems //INHERITANCE
{
    public override string Name { get => "ruby"; } //POLYMORPHISM
    public override Color Color => Color.red; //POLYMORPHISM
    public override int Hardness => 9; //POLYMORPHISM
}
