using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorPresenter : MonoBehaviour
{

    public CharactorView view;
    public KeyboardInput input; // これもViewの一部

    /*
    public CharacterModel model;
    private void Awake()
    {
        //model.moveRP.Subscribe(a => view.Move(a));
    }
    */

    private void Update()
    {
        view.Move(input.Move);
    }
}
