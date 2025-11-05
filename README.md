# 🖐️ Interactive Hand Tracking for Stroke Rehabilitation

### 🎯 Project Overview
Rehabilitation specialists often face a critical challenge: **measuring precise improvement in a patient’s motor function after each therapy session**. Traditional physiotherapy assessments for stroke or paralysis recovery are largely **subjective**, **time-consuming**, and lack quantitative measures of progress.

This project presents a **computer vision–based rehabilitation system** that combines **OpenCV**, **MediaPipe**, and the **Unity game engine** to create an **interactive, measurable, and motivating therapy environment** for patients recovering from stroke or motor impairment.

---

## 🧠 Proposed Model

A **30 fps HD MSI webcam** captures the user’s hand and continuously tracks it after registration.  
The **2D data** from the webcam is processed using **OpenCV** and **MediaPipe**, which leverage **machine learning and computer vision algorithms** for:
- Accurate **hand detection**  
- **Tracking of 21 joints** (wrist, knuckles, fingertips, etc.)

The processed data is then:
- **Broadcasted to Unity** for real-time 3D hand visualization  
- Used to calculate **motion distance** and enable **interactive features**

<img width="691" height="416" alt="image" src="https://github.com/user-attachments/assets/d12bfebf-41ae-470f-8de9-c2a12e33440a" />


---

## ⚙️ System Architecture

The workflow integrates real-time video input, ML-based hand detection, socket communication, and Unity-based visualization.

<img width="722" height="402" alt="image" src="https://github.com/user-attachments/assets/7210876d-eecc-4fe0-9ba0-f0a3297a9803" />


**Pipeline Overview:**
1. **Video Feed** → Captures live hand motion.  
2. **Hand Detection** → MediaPipe identifies 21 landmark points.  
3. **Socket Communication** → Sends data to Unity through UDP.  
4. **Unity Engine** → Visualizes and tracks hand movement in 3D.  
5. **Output** → Displays joint displacement and enables interaction.

---

## 💡 Applications

- 🩺 **Rehabilitation Therapy:**  
  Assists patients in performing and monitoring motor exercises remotely.  
- 📊 **Movement Analysis:**  
  Helps clinicians assess hand motion accuracy and range.  
- 🕹️ **Interactive Environments:**  
  Enables 2D/3D gesture-based control in games and VR.  
- 🎓 **Education & Communication:**  
  Facilitates gesture recognition systems for learning and accessibility.

---

## ⚡ Performance

- Operates at **15–20 fps** on a standard **Intel Core i5-9300H (2.4 GHz)** with **8 GB RAM**  
- Can reach **60 fps** using dedicated hardware  
- Functions in **real-time**, offering precise motion capture and displacement measurement

---

## 🔍 Key Features

- ✅ Real-time hand landmark detection  
- ✅ Accurate joint tracking using MediaPipe  
- ✅ Distance & displacement measurement  
- ✅ Live visualization in Unity  
- ✅ Configurable for interactive or clinical use  

---

## 🧩 Tech Stack

| Component | Technology Used |
|------------|-----------------|
| **Programming Language** | Python |
| **Computer Vision** | OpenCV |
| **Hand Tracking** | MediaPipe |
| **Visualization** | Unity (C#) |
| **Communication** | UDP Socket |
| **Hardware** | MSI HD Webcam |

---

## 🚀 Future Scope

- Integrate gesture-based control for robotic or virtual systems  
- Enhance tracking precision using depth estimation  
- Extend to **full-body pose tracking** for advanced rehabilitation or gaming scenarios  

---

## 👨‍💻 Contributors
**Siddharth Rana**  
*Computer Vision & AI Enthusiast*

---

## 🖼️ Preview
<img width="1433" height="311" alt="image" src="https://github.com/user-attachments/assets/76ab09f2-49a0-40ac-87fa-1d9a0c9db931" />
<img width="1013" height="520" alt="image" src="https://github.com/user-attachments/assets/0ab352ae-d44e-4f84-9b99-5b97ea58236b" />



