---
title: "RGO: A management system for the curation and re-use of research generated outputs"
tags:
    - research generated outputs
    - data re-use
authors:
    - name: James Friel
      orcid: 0009-0008-4243-5885
      equal-contrib: true
      affiliation: 1
    - name: Suzie Law
      orcid: 
      equal-contrib: true
      affiliation: 1
affiliations:
 - name: The Health Informatics Centre, University of Dundee, Dundee, United Kingdom
   index: 1
date: 10 March 2026
bibliography: paper.bib
---

# Summary

Ground truth data is data that has been reviewed and classified by a domain expert, ensuring that the data and its classification is highly accurate.
RGO is a flexible data curation and management system. It was developed to capture, curate, and allow the re-use of this ground truth data for machine learning development.
Designed to support data engineers provisioning research datasets, RGO facilitates:

* The ingestion of new ground truth data into existing data management pipelines

* Linkage between existing datasets and ingested ground truth data for cohort building purposes

* Conditional merging of existing datasets and ingested ground truth data for research project dataset provisioning

* Ground truth attribution, ensuring previous project outputs are correctly attributed

# Statement of need

In supervised machine learning, ground truth refers to the accurate and verifiable labels assigned to the dataset, typically provided by a domain expert.
This data serves as a benchmark for training and evaluating machine learning (ML) models.
The reliability of a supervised learning model is directly dependent on the quality of the ground truth data used to build the ML model [@MOHAMMED2025102549].
Ground truth data is particularly critical in research domains that may have a direct impact on a person, such as medical imaging research.
While this ground truth data is incredibly valuable, its generation is very time consuming and not a task domain experts can typically facilitate due to other commitments.
As such, the need to reuse ground truth is becoming more and more pressing as the quantity of ML based research projects increase[@MLDevelopment].

RGO was designed by, and for, data engineers to integrate with existing data pipeline and storage systems to facilitate the re-use of this ground truth data across research projects.
This integration was designed to reduce the time and cost of generating ground truth data for each research project while introducing minimal additional overheads to research dataset provisioning.

# State of the field

RGO occupies a niche area of data curation and management. While typically ground truth data is retained by the research group once a project is completed, there is currently minimal re-use of this data over time and across projects. As such, there is no solution currently available to capture and re-use research generated outputs that integrates with existing data processing pipelines and curation strategies.


# Software design

RGO is a .NET Entity Framework application that leverages an MVC pattern to decouple the user-interface from the application logic and database implementation. It supports both MicrosoftSQL and Postgres databases through the use of FansiSQL[@FansiSql]. The use of FansiSQL was chosen to allow RGO to seamlessly integrate into existing data management databases and pipelines without the need for additional database servers.

To reduce the scope of problem space for the initial RGO system, development was focused on the re-use of tabular ground truth data, while designing the system in a manner that would be extendable for non-tabular data, such as ML models, in future releases.

As there is no fixed definition of what ground truth data should look like, the system was designed to be as flexible as possible to support the majority of ground truth data.
To enable this, users define templates for the structure of an expected dataset before the dataset is uploaded to the RGO system.
To reduce the complexity of using this system, a dataset template  has only two requirements:
1.	Column(s) to identify the entity being labelled (e.g. anonymised image identifier or pseudonymous identifier) 
2.	Column(s) containing the ground truth labels 
This design allows for flexibility for users describing and storing ground truth datasets. The addition of description fields and optional labelling within the system allows for improved understandability and usability for future users.

Due to the flexible nature of the data structures managed by the RGO system, it was decided to deconstruct each uploaded dataset and dataset record into a standardised format that can be reconstructed for future use.
This deconstruction created individual cell records across a number of tables, an example of this can be seen in appendix item 1. Restructuring this data simply involved collating cell records for the dataset and recreating the expected structure from the defined template.
Evaluation of this destucturing and restucturing process proved that RGO can deconstruct and reconstruct a 100m record dataset in under 3 minutes. We believe this time delay is a reasonable tradeoff to allow the data to be managed and queried in a standardised format.


# Research impact statement

The RGO system is currently deployed and in use within the Electronic Data Research and Innovation Service (eDRIS) within Public Health Scotland (PHS).
This deployment has produced 10 reusable RGOs from a variety of projects. These include:
*	Extracted clinical terms from Structured Radiologist Reports (via NLP)
*	Labelling of MRI brain scans
*	MRI brain parcellation volumes
*	MRI brain intracranial volumes
*	CT & MRI image annotations
*	Demographic data for patients with brain scans
*	History of health service interaction for patients with brain scans

Since producing these RGOs, 4 studies have been approved to use these RGOs. Three of these projects are traditional brain-imaging projects, including the development of machine-learning models.
The fourth study leverages the Structured Reports RGO, which has allowed them to re-use the extracted clinical terms derived by this RGO rather than extract this data themselves from electronic healthcare records.
This has not only removed and duplication of effort in this task, but is also an example of the data minimisation enabled by the use of RGOs

# AI usage disclosure

No generative AI tools were used in the development of this software, the writing of this manuscript, or the preparation of supporting materials.

# Acknowledgements
We would like to thank the eDRIS team for their support in the development of the RGO system.

# Citations

# References

# Appendix
## 1. Example dataset destructuring 
### Example Ground Truth dataset uploaded by researcher
| Image Location | Identifier | Ground Truth Value | Exam Date |
| --- | --- | --- | --- |
| /images/1.jpg | PC123 | T1 | 11/07/24 |
| /images/2.jpg | PC245 | T2 | 12/07/24 |
| /images/3.jpg | PC135 | T1 | 11/07/24 |
| ...| ... | ... | ... |

### RGO Dataset Table

| ID | Name | DOI |
| --- | --- | --- |
| 1 | CT Head Scans | TBD |

### RGO Records Table

| ID | RGO_DatasetID |
| --- | --- |
| 1 | 1 |
| 2 | 1 |
| 3 | 1 |

### RGO Columns Table
| ID | RGO_RecordID | Name | Type | Value |
| --- | --- | --- | --- | --- |
| 1 | 1 | Image Location | string | /images/1.jpg |
| 2 | 1 | Identifier | string | PC123 |
| 3 | 1 | Ground Truth Value | string | T1 |
| 4 | 1 | Exam Date | datetime | 11/07/24 |
| 5 | 2 | Image Location | string | /images/2.jpg |
| 6 | 2 | Identifier | string | PC245 |
| 7 | 2 | Ground Truth Value | string | T2 |
| 8 | 2 | Exam Date | datetime | 12/07/24 |
| 9 | 3 | Image Location | string | /images/3.jpg |
| 10 | 3 | Identifier | string | PC135 |
| 11 | 3 | Ground Truth Value | string | T1 |
| 12 | 3 | Exam Date | datetime | 11/07/24 |