using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Test_Player : MonoBehaviour
    {
        [SerializeField] public GameObject testGameobject;

       public GameObject[] ArrayGameObjects;

       public List<GameObject> ListGameObjects;

      
        public string publicText= "KubopNaoya";

        // Start is called before the first frame update
        void Start()
        {
        //Debug.Log("testGameobject.name=== " + testGameobject.name);

        //Debug.Log(ListGameObjects[1].name);
        //ListGameObjects[1].GetComponent<Renderer>().material.color = Color.red;
    }

        // Update is called once per frame
        void Update()
        {

        }

        private void Pri_Test_Fuc(string text)
        {

            //Debug.Log("Pri_Test_Fuc()の呼び出しが行われました"+ text);
        }
    }
