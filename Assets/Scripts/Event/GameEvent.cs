using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;
using UnityEngine.UIElements;

public class GameEvent : NetworkBehaviour
{
	protected virtual string eventName() => "name";
	// 継承する用のスタート関数
	public virtual void StartEvent() {}

	public string GetEventName(){
		return eventName();
	}
}
