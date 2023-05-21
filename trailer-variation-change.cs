var asset = ToolsModifierControl.toolController.m_editPrefabInfo as VehicleInfo;
var variation = 0;
foreach(var trailers in asset.m_trailers){
  for(int i = 0; trailers.m_info.m_subMeshes.Length > i; i++){
  variation = Convert.ToInt32(Math.Pow(2, i));
  trailers.m_info.m_subMeshes[i].m_variationMask = variation;
  if(i == 0)
  {
    trailers.m_info.m_mesh.name = Convert.ToString("TrailerVariation "+variation);
      }
      else {
        trailers.m_info.m_subMeshes[i].m_subInfo.m_mesh.name = Convert.ToString("TrailerVariation "+variation);
     }
  }
}
