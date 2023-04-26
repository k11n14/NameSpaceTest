using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Test_Weapons : MonoBehaviour
{
    public Test_Player test_Player;

    //public GameObject public_test_Gameobject;

    private GameObject _testGameobject;

    private Renderer _renderer;

    private Material _material;

    private Color _buleColor= Color.blue;
    private Color _yellowColor = Color.yellow;

    // Start is called before the first frame update
    void Start()
    {

        //test_Player.ListGameObjects[1].GetComponent<Renderer>().material.color = _color;


        _testGameobject = test_Player.ListGameObjects[1];


        Debug.Log(_testGameobject);

        _renderer = _testGameobject.GetComponent<Renderer>();

        Debug.Log(_renderer);

        _material = _renderer.material;

        Debug.Log(_material);

        _material.color = _yellowColor;

    }
}