# DSA-20Days-Array-Challenge
# Day 1 – Two Sum

## 🔍 Problem Statement

Given an array of integers `nums` and an integer `target`, return indices of the two numbers such that they add up to `target`.

## 💡 Approach

- Use a dictionary to store previously seen numbers and their indices.
- For each number, check if `target - number` exists in the dictionary.

## 🧪 Example

```csharp
Input: nums = [2, 7, 11, 15], target = 9  
Output: [0, 1]
