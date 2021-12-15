using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blunderbuss : MonoBehaviour, IEquipableItem
{
    public Transform _playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        var obj = col.gameObject;

        this.transform.SetParent(_playerTransform, true);
        this.transform.position = new Vector2(_playerTransform.position.x + 1, _playerTransform.position.y);
        this.transform.rotation = _playerTransform.rotation;
    }
}
