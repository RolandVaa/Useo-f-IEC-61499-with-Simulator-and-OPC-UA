# IEC 61499 with Simulator & OPC UA – Completed Control Application

This project implements the full Lab 4 workflow for developing a distributed industrial control application using **EcoStruxure Automation Expert (EAE)**, **Visual Components (VC)**, and **OPC UA** communication.  
The system targets a digital twin of the **EnAS demonstrator**, a closed-loop production line with conveyors, jacks, and a Robotino AGV.  
All tasks described in the lab guide have been completed. :contentReference[oaicite:1]{index=1}

---

## Overview of the EnAS Demonstrator

According to the guide (page 2), the EnAS demonstrator replicates an industrial assembly line with six conveyors, pneumatic jacks, sensors, and an AGV for delivering workpieces. A detailed simulation model is provided in Visual Components and interacts with EAE through OPC UA.  
All described interactions between the softPLC and the VC simulation have been fully implemented. :contentReference[oaicite:2]{index=2}

---

## Completed Tasks

### ✔ Control Application Setup (SOA Architecture)
The full SOA-based architecture described on page 4 has been implemented, including:
- **Execution Services**: Conveyor FBs, Jack FBs, and Robotino FB  
- **Planning Services**: Delivery Services and Placement Services  
- **Production Services**: Composite FB with internal recipe logic  
All FBs communicate through adapters exactly as designed in the diagram. :contentReference[oaicite:3]{index=3}

---

## ✔ Conveyor, Jack, and Robotino Behavior

### Conveyors  
All three operational modes described on page 5 have been implemented:
- C mode: continuous movement  
- P mode: pass-through behavior  
- D mode: delivery with confirmation  
The sequence `<C4, P5, P6, P1, D2>` from page 6 has been reproduced and validated. :contentReference[oaicite:4]{index=4}

### Pneumatic Jacks  
Both Jack 1 and Jack 2 support all four operations (J1P, J1R, J2P, J2R), with correct sensor-based confirmation messages.  
The “PLACE D” and “REMOVE D” confirmations described on page 6 have been implemented. :contentReference[oaicite:5]{index=5}

### Robotino AGV  
Robotino responds to `R Start` and delivers empty workpieces to Conveyor 1, producing a correct `R DONE` confirmation event.  
The AGV logic matches the interface on page 7. :contentReference[oaicite:6]{index=6}

---

## ✔ Production Recipe Development

The required updates to the **Product Recipe FB** have been completed:
- ECC expanded to implement a multi-step production sequence  
- Interface modifications introduced as needed  
- A sequence of **10+ operations** created combining conveyor and jack functions  
- Each jack performs at least one pick and one place  
- Conveyor actions inserted between jack actions to meet constraints  
- A **3-second delay** added at the 5th operation using `E_DELAY` (requirement 4)  
- Correct behavior implemented for **Reset**, sending a “Reset All” event and returning to the initial state  

All requirements from section 4.2 have been fulfilled. :contentReference[oaicite:7]{index=7}

---

## ✔ OPC UA Integration with Visual Components

The softPLC has been deployed using the steps listed on page 11, including:
- Starting runtime simulation  
- Deploying device configuration  
- Starting the OPC UA server in EAE  

VC has been connected as an OPC UA client:
- Connectivity Add-On enabled  
- Model loaded  
- Successful connection established (green indicator)  
- Simulation controlled through the EAE HMI  

All steps from section 4.4 have been completed. :contentReference[oaicite:8]{index=8}

---

## System & HMI Media

### System Demonstration (Video)
A video showcasing:
- HMI interaction  
- Production recipe execution  
- Conveyor and jack movements  
- Robotino AGV delivery  
- OPC UA-driven VC simulation  

<video src="video1830025706.mp4" controls width="600"></video>
