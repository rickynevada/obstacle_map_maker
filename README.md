# obstacle_map_maker
This program will help draw and generate maps for simulations with robotics path planning and navigation algorithms. It will also convert various types of maps from images or other ASCII files.

## How to Use
Currently the map maker only works maximized, and the canvas (drawing area) cannot be rescaled or zoomed. This was meant to be a quick tool to generate/convert maps, and not be a full fledged drawing application.

### Create new map
To begin. Select the size of map you want, enter a start and goal location, and hit create. The base map should be drawn to the canvas.

### Modify Map
From the toolbox, select what you want to draw, you can free draw, draw rect, draw waypoints, and change start/goal locations. You can also add waypoints, and adjust the order of them. If you want to delete things you've drawn, select 'No Obstacle'.

### Generate Map
Once your map is complete, you can click 'Generate' and this will open a new window. On your first line is the map dimensions, always map size by map size (NxN). Second line is start and goal location, with waypoints in between. Finally the bulk of the map file is your map. 1's are obstacles and 0's are freespace. You can either copy and paste elsewhere, or click 'Save Map' to save the map as a text file.

### Conversions
Finally, two other features are added that I've found useful, the first it a conversion from a .map file, to convert maps found here: [Moving AI Benchmarks](https://movingai.com/benchmarks/mapf/index.html) and the other is a conversion from image. The process I found was that if I saw a map on someone else's paper, I would take a screenshot, using paint, resize to be perfectly square, make sure obstacles are black, then convert the image in obstacle_map_maker to my map file standard for comparison studies. Also, if you want complex shapes, you can hand draw your map in paint or another similar program, save the image, and convert in this program if you don't like using the basic draw features provided here.

