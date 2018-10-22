using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorVisitor : Visitor
{
    private Ray ray;

    public Camera mainCamera;

    public override void Visit(ItemAcceptor acceptor)
    {
        acceptor.Accept(this);
        Debug.Log("アイテムを取得する処理");
    }

    public override void Visit(DoorAcceptor acceptor)
    {
        acceptor.Accept(this);
        Debug.Log("フィールドを移動する処理");
    }

    public override void Visit(ActorAcceptor acceptor)
    {
        acceptor.Accept(this);
        Debug.Log("会話モードへ移行する処理");
    }
    
    void Start()
    {
        ray = new Ray();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                GameObject game = hit.collider.gameObject;

                ItemAcceptor item = game.GetComponent<ItemAcceptor>();
                if (item != null) Visit(item);

                DoorAcceptor door = game.GetComponent<DoorAcceptor>();
                if (door != null) Visit(door);

                ActorAcceptor actor = game.GetComponent<ActorAcceptor>();
                if (actor != null) Visit(actor);
            }
        }
    }
}
