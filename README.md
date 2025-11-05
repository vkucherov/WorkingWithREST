# Medical Records Fetcher (C#)

A simple C# console application that demonstrates how to:
- Fetch and deserialize paginated JSON data from an API  
- Handle asynchronous HTTP requests using `HttpClient`
- Parse data into strongly typed models
- Use LINQ to filter and extract unique field values

---

## Overview

This project connects to a mock API from HackerRank:
https://jsonmock.hackerrank.com/api/medical_records?userId=1&page=1

It automatically retrieves all pages of results, deserializes them into C# objects, and collects them in a single list (`AllRecords`).  
Once loaded, the data can be processed — for example, extracting all unique patient names using LINQ.

---

## What You Learn

- How to call REST APIs with `HttpClient`
- How to deserialize JSON into C# classes using `System.Text.Json`
- How to work with pagination
- How to use LINQ to transform and filter data
