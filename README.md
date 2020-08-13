# Structure to organize

Hierarchical tree structure to organize my assets in my enterprise

## Features

User can:
1	See the tree.
2	Use expand/collapse all button 
3	Create/update/delete an organization
4	Create/update/delete a country under organization.
5	Create/update/delete a business inside country (the business has to be unique inside a country). 
6	Create/update/delete a family inside business (the family must be unique inside a business)
7	Create/update/delete an offering inside family (the offering must be unique inside a family).
8	Create/update/delete a department (Validation rule: the department name must be unique inside the offering). 
9	To see logs or exceptions that happened inside the system. 
10	If a user delete upper level, all bottom levels needs to be deleted. 
11	User must be authenticated using external providers (Google), 
12	All GET methods must be accessible without authentication. 
