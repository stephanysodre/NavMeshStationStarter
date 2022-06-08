using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    GameObject[] agents;
    // Use this for initialization
    void Start()
    {
        // busca pela tg ai
        agents = GameObject.FindGameObjectsWithTag("ai");
    }
    // Update is called once per frame
    void Update()
    {
        // objeto faz açao ao clikar
        if (Input.GetMouseButtonDown(0))
        {
            // obetem informaçao
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                foreach (GameObject a in agents)
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
            }
        }
    }
}
