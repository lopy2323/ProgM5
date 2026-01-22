using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;

public class Inventory : MonoBehaviour
{

private List<Armor>  _armorsinv = new List<Armor>();
private List<Weapon> _weaponsinv = new List<Weapon>();
private List<Potion> _potionsinv = new List<Potion>();

private List<Armor> _armormap = new List<Armor>();
private List<Weapon> _weaponmap = new List<Weapon>();
private List<Potion> _potionmap = new List<Potion>();

    private int _droppingIndex = 0;


    [SerializeField]private List<GameObject> _dropAbole = new List<GameObject>();

    private GameObject _Selected;

    private void Start()
    {
        getAmount();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _droppingIndex++;
            IntSelected();
            Debug.Log(_droppingIndex);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _droppingIndex--;
            IntSelected();
            Debug.Log(_droppingIndex);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            DropItem();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            getAmount();
            Debug.Log("Armors in Inventory: " + _armorsinv.Count);
            Debug.Log("Weapons in Inventory: " + _weaponsinv.Count);
            Debug.Log("Potions in Inventory: " + _potionsinv.Count);

            Debug.Log("Armors on Ground: " + _armormap.Count);
            Debug.Log("Weapons on Ground: " + _weaponmap.Count);
            Debug.Log("Potions on Ground: " + _potionmap.Count);

            BaseItem[] items = FindObjectsByType<BaseItem>(FindObjectsSortMode.None);
            Debug.Log("Total Item on the Ground: " + items.Length);
        }

    }
    private void DropItem()
    {
        if (_droppingIndex == 1)
        {
            if (_armorsinv.Count <= 0) return;
        }
        if (_droppingIndex == 2)
        {
            if (_weaponsinv.Count <= 0) return;
        }
        if (_droppingIndex == 3)
        {
            if (_potionsinv.Count <= 0) return;
        }
        var SpawnPostion = new Vector3(transform.position.x - 4, transform.position.y, transform.position.z);
        Instantiate(_Selected, SpawnPostion + transform.forward, Quaternion.identity);
        if (_droppingIndex == 1)
        {
            _armorsinv.RemoveAt(0);
            Debug.Log("Dropped Armor");
            Debug.Log(_armorsinv.Count);
        }
        if (_droppingIndex == 2)
        {
            _weaponsinv.RemoveAt(0);
            Debug.Log("Dropped Weapon");
            Debug.Log(_weaponsinv.Count);
        }
        if (_droppingIndex == 3)
        {
            _potionsinv.RemoveAt(0);
            Debug.Log("Dropped Potion");
            Debug.Log(_potionsinv.Count);
        }
        getAmount();
    }
    private void IntSelected()
    {
        if (_droppingIndex < 0)
        {
            _droppingIndex = 3;
        }
        if (_droppingIndex == 1)
        {
            _Selected = _dropAbole[0];
        }
        if (_droppingIndex == 2)
        {
            _Selected = _dropAbole[1];
        }
        if (_droppingIndex == 3)
        {
            _Selected = _dropAbole[2];
        }
        if (_droppingIndex > 3)
        {
            _droppingIndex = 0;
        }
    }
    private void getAmount()
    {
        List<GameObject> foundObjects = new List<GameObject>();

        _armormap.Clear();
        _weaponmap.Clear();
        _potionmap.Clear();

        foundObjects.AddRange(GameObject.FindGameObjectsWithTag("Pickup"));
        foreach (var item in foundObjects)
        {
            if (item == null) continue;
            if (!item) continue;
            if (item.TryGetComponent<Armor>(out Armor ar))
            {
                _armormap.Add(ar);
            }
            else if (item.TryGetComponent<Weapon>(out Weapon we))
            {
                _weaponmap.Add(we);
            }
            else if (item.TryGetComponent<Potion>(out Potion po))
            {
                _potionmap.Add(po);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<Armor>(out Armor armor))
        {
            _armorsinv.Add(armor);
            _armormap.Remove(armor);
            Destroy(other.gameObject);
            getAmount();
        }
        else if (other.gameObject.TryGetComponent<Weapon>(out Weapon weapon))
        {
            _weaponsinv.Add(weapon);
            _weaponmap.Remove(weapon);
            Destroy(other.gameObject);
            getAmount();
        }
        else if (other.gameObject.TryGetComponent<Potion>(out Potion potion))
        {
            _potionsinv.Add(potion);
            _potionmap.Remove(potion);
            Destroy(other.gameObject);
            getAmount();
        }
    }
    
}
