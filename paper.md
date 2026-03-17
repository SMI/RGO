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
The reliability of a supervised learning model is directly dependent on the quality of the ground truth data used to build the ML model [].
Ground truth data is particularly critical in research domains that may have a direct impact on a person, such as medical imaging research.
While this ground truth data is incredibly valuable, its generation is very time consuming and not a task domain experts can typically facilitate due to other commitments.
As such, the need to reuse ground truth is becoming more and more pressing as the quantity of ML based research projects increase[].

RGO was designed by, and for, data engineers to integrate with existing data pipeline and storage systems to facilitate the re-use of this ground truth data across research projects.
This integration was designed to reduce the time and cost of generating ground truth data for each research project while introducing minimal additional overheads to research dataset provisioning.

# State of the field

RGO occupies a niche area of data curation and management. While typically ground truth data is retained by the research group once a project is completed, there is currently minimal re-use of this data over time and across projects. As such, there is no solution currently available to capture and re-use research generated outputs that integrates with existing data processing pipelines and curation strategies.


# Software design

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

