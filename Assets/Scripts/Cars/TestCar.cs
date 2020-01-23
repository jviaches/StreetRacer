using Assets.Scripts.Cars;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCar : ICar
{
    public int Id { get => 1; }
    public string Name { get => "Test Car"; }
    public float TopSpeed { get => 3; }
    public float Cost { get => 10; }
    public float Durability { get => 10; }
}
