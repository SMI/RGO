## eDRIS Procedure notes for capturing and reusing RGO

<details>
  
<summary>Project Startup</summary>

Work with the Research Group to:

- Identify RGO that the project will create
- Identify any previously captured RGO that the project would like to extract
- 

It is important to ensure that the Researchers know that it is their responsibility to validate any data that they return.  The RGO tool cannot validate a different dataset for each project.

</details>

<details>
  
<summary>RGO Setup and Preparation</summary>

- Create the Group
  The group represents the Research Project.  You can include contact details in here if you want but these should be only for your own use, and not shared
- Create the Ground Truthers (if required)
  Not yet clear to what extent this will be used
- Create the RGO Output
  A record that represents an output.  If RGO is further developed there will be other flavours of RGO, in addition to Ground Truth.  
- Create the RGO Dataset Template and associated RGO Column Templates
  A Ground Truth RGO is described using an RGO Dataset Template record (and associated RGO Column Template Records). Other types of RGO (in the future) will have different tables created to capture information about them (e.g. RGO_Algorithm or RGO_Tool)
- Download an empty sample file to give to the Research project
  This shows the researchers
  1. What the name of the file should be (although it can be CSV or XLS).  Note that the name can be different from what is generated, but to upload successfully once populated, the filename must be RGO<whatever>n where n is the dataset identifier.  The samplefile will automatoically have this number at the end of its name
  2. What the column_names must be
  3. If ground truthers are to be identified, it will include a list of the names that can be used

</details>
<details>

<summary>Upload the Ground Truth file</summary>

Using the Upload screen

</details>

<details>

<summary>Integrate the RGO with our standard clinical data</summary>

Consider how eDRIS would like this to work, and how to ensure the security of any potentially disclosive data

</details>

<details>

<summary>End of Project review</summary>

How can eDRIS check that the ground truth identified at the start has been successfully gathered

</details>

<details>

<summary>Maintain Evidence</summary>

Add publications, requests to extract existing RGO etc.  

</details>
