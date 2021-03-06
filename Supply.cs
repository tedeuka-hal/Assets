﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BattleScene
{ 
    public class Supply : MonoBehaviour {

        [SerializeField]
        private ScrollRect m_SupplyScroll;
    
        public void AddSupply(Card card)
        {
            card.State = Card.CardState.SUPPLY;
            card.transform.SetParent(m_SupplyScroll.content);
        }
    }
}