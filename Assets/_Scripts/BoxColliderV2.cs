using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class BoxColliderV2 : ColliderV2
{
    //default box settings v
    public Vector3 Center = Vector3.zero;
    public Vector3 Size = Vector3.one;

    //box collider inner variables
    private Vector3 colliderCenter;
    private Vector3 colliderSize;

    private void Awake()
    {
        SetCenter();
        SetSize();
    }

    protected override void CheckCollision()
    {
        if (isTrigger)
        {

            {
                //OnTrigger();
            }
        }
        else
        {

            {
                //onCollision();
            }
        }
    }

    private void SetCenter()
    {
        //if pivot point isn't default
        if (Center != Vector3.zero)
        {
            //set collider center data by variables given
            colliderCenter.x = transform.position.x + Center.x;
            colliderCenter.y = transform.position.y + Center.y;
            colliderCenter.z = transform.position.z + Center.z;
        }
        //if collider center is default, use objects' position
        else
        {
            colliderCenter = transform.position;
        }
    }

    private void SetSize()
    {
        //if collider size not default
        if (Size != Vector3.one)
        {
            //set collider size data by variables given
            colliderSize.x = transform.localScale.x * Size.x;
            colliderSize.y = transform.localScale.y * Size.y;
            colliderSize.z = transform.localScale.z * Size.z;
        }
        //if collider size default, use objects' scale
        else
        {
            colliderSize = transform.localScale;
        }
    }

    private void OnDrawGizmosSelected()
    {
        //if bool show is on
        if (ShowCollider)
        {
            //set collider
            SetCenter();
            SetSize();
            //draw collider
            Gizmos.color = Color.green;
            Gizmos.DrawWireCube(colliderCenter, colliderSize);
        }
    }
}