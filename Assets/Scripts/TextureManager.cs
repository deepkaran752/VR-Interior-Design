using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TechXR.Core.Sense;

public class TextureManager : MonoBehaviour
{

    public Animator menuCanvas;
    public Transform menuContainer, playerHead;
    public MeshRenderer startGobj;

    private MeshRenderer currentGobj;

    // Start is called before the first frame update
    void Start()
    {
        currentGobj = startGobj;
    }

    // Update is called once per frame
    void Update()
    {
        if(SenseInput.GetButtonDown(ButtonName.C))
        {
            menuCanvas.SetTrigger("openclose");
        }

        menuContainer.eulerAngles = new Vector3(menuContainer.eulerAngles.x, playerHead.eulerAngles.y, menuContainer.eulerAngles.z);
    }

    public void SetGameObjectType(MeshRenderer gameObj)
    {
        currentGobj = gameObj;
    }

    public void SetTextureOfGameObj(Texture texture)
    {
        currentGobj.material.mainTexture = texture;
    }
}
