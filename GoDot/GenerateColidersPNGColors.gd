extends Node

# class member variables go here, for example:


func _ready():
    # Called every time the node is added to the scene.
    # Initialization here
    pass

func get_shape_pixels(Image i):
    var shape = [];
    for (var y = 0; y < i.get_height(); y++):
    	shape.append(get_shape_loc_color(i, y));
    
func get_shape_loc_color(Image i, int y):
    var shape_row = []
    for (var x = 0; x < i.get_width(); x++):
        var pixel = i.get_pixel(x, y);
        if (pixel.a != 0.0):
            shape_row.append({'x': x, 'y': y, 'color': pixel });
   return shape_row;
