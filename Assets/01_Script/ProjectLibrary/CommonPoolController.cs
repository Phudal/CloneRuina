using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������Ʈ Ǯ ��Ʈ�ѷ�
public class CommonPoolController : MonoBehaviour
{
    public List<GameObject> poolList;
    public GameObject Prefab;

    void Awake()
    {
        setList();
    }

    public void setList()
    {
        if (poolList == null)
            poolList = new List<GameObject>();

        //poolList.Clear();
        for (int i = 0; i < transform.childCount; i++)
        {
            GameObject ob = transform.GetChild(i).gameObject;
            poolList.Add(ob);
            ob.SetActive(false);
        }
    }

    public void ReturnPool(GameObject ob)
    {
        if (ob != null)
        {
            ob.transform.SetParent(gameObject.transform);
            ob.transform.localPosition = Vector3.zero;
            ob.transform.localScale = Vector3.one;

            ob.SetActive(false);
        }
    }

    public void Hide()
    {
        for (int i = 0; i < poolList.Count;)
        {
            GameObject ob = poolList[i];
            if (ob == null)
            {
                poolList.RemoveAt(i);
                continue;
            }

            ob.transform.SetParent(gameObject.transform);
            ob.transform.localPosition = Vector3.zero;
            ob.transform.localScale = Vector3.one;
            
            ob.SetActive(false);
            i++;
        }
    }

    public void Clear()
    {
        for (int i = 0; i < poolList.Count; i++)
        {
            GameObject.Destroy(poolList[i]);
        }

        poolList.Clear();
    }

    /// <summary>
    /// Ư�� �̸��� ���� ������Ʈ�� �������ش�
    /// </summary>
    /// <param name="name">ã�� �̸�</param>
    /// <returns>�ش�Ǵ� �̸��� ���� ù��° ������Ʈ</returns>
    public GameObject getObjectByName(string name)
    {
        for (int i = 0; i < poolList.Count; i++)
        {
            GameObject ob = poolList[i];
            if (ob.name.Equals(name))
            {
                return ob;
            }
        }

        return null;
    }

    // ������ �ִ� Ǯ���� �ϳ��� �̾� �´�.
    public T GetPoolItem<T>() where T : new()
    {
        if (poolList == null)
        {
            setList();
        }

        GameObject ob = null;
        for (int i = 0; i < poolList.Count; i++)
        {
            ob = poolList[i];

            if (ob == null)
                continue;

            if (ob.activeSelf == false)
            {
                break;
            }

            ob = null;
        }

        if (ob == null)
        {
            ob = Instantiate(Prefab);

            if (poolList == null)
            {
                poolList = new List<GameObject>();
            }

            poolList.Add(ob);
            return ob.GetComponent<T>();
        }
        else
        {
            return ob.GetComponent<T>();
        }
    }
}