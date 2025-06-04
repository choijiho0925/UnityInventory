using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condition : MonoBehaviour
{
    private int health = 100;
    public int Health { get { return health; } set { health = Mathf.Clamp(value, 0, 100); } }
    private int reactionSpeed = 203;
    private int ReactionSpeed { get { return reactionSpeed; } set { reactionSpeed = Mathf.Clamp(value, 0, 1000); } }
    private int IQ = 130;
    public int IQLevel { get { return IQ; } set { IQ = Mathf.Clamp(value, 0, 200); } }
    private int codingPower = 30;
    public int CodingPower { get { return codingPower; } set { codingPower = Mathf.Clamp(value, 0, 100); } }
}