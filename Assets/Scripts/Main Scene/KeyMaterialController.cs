using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMaterialController : MonoBehaviour
{
    Color gameObjectDefaultMaterialColor;
    
    // Start is called before the first frame update
    void Start()
    {
        var gameObjectRenderer = this.gameObject.GetComponent<Renderer>();
        gameObjectDefaultMaterialColor = gameObjectRenderer.material.GetColor("_Color");

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(delayExecute());
    }
    IEnumerator delayExecute()
    {
        var currentGameObjectRenderer = this.gameObject.GetComponent<Renderer>();

        if (currentGameObjectRenderer.material.GetColor("_Color") 
            != gameObjectDefaultMaterialColor)
        {
            yield return new WaitForSeconds(0.5f);
            currentGameObjectRenderer.material
                .SetColor("_Color", gameObjectDefaultMaterialColor);
        }
    }
}
