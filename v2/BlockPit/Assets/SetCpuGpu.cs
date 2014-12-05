using System.Runtime.InteropServices;
using UnityEngine;
using System.Collections;

public class SetCpuGpu : MonoBehaviour {
	[DllImport("OculusPlugin")]
	// Set the fixed CPU clock level.
	private static extern void OVR_VrModeParms_SetCpuLevel( int cpuLevel );
	
	[DllImport("OculusPlugin")]
	// Set the fixed GPU clock level.
	private static extern void OVR_VrModeParms_SetGpuLevel( int gpuLevel );

	void Start () {
	}

	void Awake () {
#if UNITY_ANDROID && !UNITY_EDITOR
		OVR_VrModeParms_SetCpuLevel( 3 );
		OVR_VrModeParms_SetGpuLevel( 1 );
#endif
	}
}
