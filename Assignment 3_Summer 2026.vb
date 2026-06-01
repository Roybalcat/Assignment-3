import pandas as pd
import matplotlib.pyplot as plt
from sklearn.datasets import load_iris

#Question 1 Load the iris dataset and Plot a histogram of the Sepal Width 
iris = load_iris()
df = pd.DataFrame(iris.data, columns=iris.feature_names)
plt.hist(df['sepal width (cm)'])
plt.show()



#Question 2 Find the mean, and the median of the Sepal Width 
df = pd.DataFrame(iris.data, columns=iris.feature_names)
print("Mean of Sepal Width:", df['sepal width (cm)'].mean())
print("Median of Sepal Width:", df['sepal width (cm)'].median())
print("Mean of Sepal Width:", df['sepal width (cm)'].mean())
print("Median of Sepal Width:", df['sepal width (cm)'].median())    


Question 3 Only 27% of the flowers have a Sepal Width higher than ________ cm
threshold = df['sepal width (cm)'].quantile(0.73)
print(f"27% of the flowers have a Sepal Width higher than {threshold:.27f} cm.")

Question 4 e catterplots of each pair of the numerical variables in iris 
plt.scatter(df['sepal length (cm)'], df['sepal width (cm)'])
plt.scatter(df['sepal length (cm)'], df['petal length (cm)
plt.scatter(df['sepal length (cm)'], df['petal width (cm)'])
plt.scatter(df['sepal width (cm)'], df['petal length (cm)'])
plt.scatter(df['sepal width (cm)'], df['petal width (cm)'])
plt.scatter(df['petal length (cm)'], df['petal width (cm)'])
plt.show()

#Using the PlantGrowth dataset...
import pandas as pd
data = { "weight": [4.17, 5.58, 5.18, 6.11, 4.50, 4.61, 5.17, 4.53, 5.33, 5.14, 4.81, 4.17, 4.41, 3.59, 5.87, 3.83, 6.03, 4.89, 4.32, 4.69, 6.31, 5.12, 5.54, 5.50, 5.37, 5.29, 4.92, 6.15, 5.80, 5.26], "group": ["ctrl"] * 10 + ["trt1"] * 10 + ["trt2"] * 10}
PlantGrowth = pd.DataFrame(data)

#a. histogram of the variable weight with breakpoints (bin edges) at every 0.3 units, staring at 3.3
import matplotlib.pyplot as plt
plt.hist(PlantGrowth['weight'], bins=np.arange(3.3, PlantGrowth['weight'].max() + 0.3, 0.3))
plt.xlabel('Weight')
plt.ylabel('Frequency')
plt.title('Histogram of Plant Weights')
plt.show()  

#b Makeboxplots of weight seperated by group in a single graph
plt.boxplot([PlantGrowth[PlantGrowth['group'] == 'ctrl']['weight'], 
             PlantGrowth[PlantGrowth['group'] == 'trt1']['weight'], 
             PlantGrowth[PlantGrowth['group'] == 'trt2']['weight']], 
            labels=['ctrl', 'trt1', 'trt2'])
plt.xlabel('Group')
plt.ylabel('Weight')
plt.title('Boxplots of Plant Weights by Group')
plt.show()

#2d	approximately what percentage of the "trt1" weights are below the minimum "trt2" weight
trt1_weights = PlantGrowth[PlantGrowth['group'] == 'trt1']['weight']
trt2_min_weight = PlantGrowth[PlantGrowth['group'] == 'trt2']['weight'].min()
percentage_below_trt2_min = (trt1_weights < trt2_min_weight).mean() * 100
print(f"Approximately {percentage_below_trt2_min:.2f}% of the 'trt1' weights are below the minimum 'trt2' weight.")

#2e	Only including plants with a weight above 5.5
#  make a barplot of the variable group
# Make the barplot colorful using some color palette 
import seaborn as sns
filtered_plants = PlantGrowth[PlantGrowth['weight'] > 5.5]
sns.countplot(x='group', data=filtered_plants, palette='coolwarm')  
plt.xlabel('Group')
plt.ylabel('Count') 
plt.title('Barplot of Groups for Plants with Weight > 5.5')
plt.show()  




