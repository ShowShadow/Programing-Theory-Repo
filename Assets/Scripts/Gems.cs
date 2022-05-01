using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gems : MonoBehaviour //INHELITANCE
{
    public abstract string Name { get; } //ENCUPSULATION

    public virtual Color Color
    {
        get => Color.white;
        set => Color = value;
    } //ENCUPSULATION

    public virtual int Hardness
    {
        get => 10;
        set => Hardness = value >= 10 ? 10 : value;
    } //ENCUPSULATION

    public virtual string DisplayText()
    {
        string result = $"The {GetColor()} {Name}'s hardness is {Hardness}.";
        return result;
    }//ABSTRACTION

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color;
    }

    string GetColor()
    {
        if(Color == Color.red)
            return "red";
        else if(Color == Color.blue)
            return "blue";
        else if(Color == Color.white)
            return "shine";
        return Color.ToString();
    }
}
