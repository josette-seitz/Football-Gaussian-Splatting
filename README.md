# 🏈 Gaussian Splatting Football Demo

A Unity-based visualizer showcasing how a real football can be scanned, splatted, and thrown in XR using Gaussian Splatting techniques.  
This demo is focused specifically on sports object capture for immersive football training and interaction.

## 🎥 Workflow Overview

1. **📸 Scan Football at 4K 30FPS**  
   A small autographed football is filmed using 4K 30FPS video for high-detail capture.

2. **🧊 Import Scan into Postshot**  
   The footage is processed in Postshot to generate Gaussian Splat point cloud data with preserved surface texture and depth.

3. **🧼 Cleanup & Export PLY**  
   Unnecessary splat noise is removed and the football model is cleaned up for export. Final output is in `.PLY` format.

4. **🎮 Import PLY into Unity3D**  
   The splat point cloud is loaded into Unity with PLY parsing and rendered using a custom Gaussian shader.

5. **🤲 Add Physics & Interactions**  
   XR Grab Interactable and Rigidbody physics are added. Players can grab the football with controller grip input and throw it.

## 🚀 Features

- ✅ Real scanned football imported as splat point cloud
- ✅ 4K resolution-based volumetric accuracy
- ✅ Throwable physics using XR Interaction Toolkit
- ✅ Full pipeline from capture to interactive XR deployment

## 🛠️ Tech Stack

- Unity 2022+
- Postshot Gaussian Splatting Pipeline
- Unity PLY Importer
- XR Interaction Toolkit 
- C# 
- PCVR (SteamVR/OpenXR)

## 📝 License

Private/internal use only – property of StatusPro.
