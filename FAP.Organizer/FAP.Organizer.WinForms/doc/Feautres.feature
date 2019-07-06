Feature: FAP Organizer
	In order to have a better experience during my relax time
	As a common user 
	I want to organize my collection of resources
	
# Load Images
@completed
Scenario:  Load an image resource from computer
	Given an image resouce is selected
	When the resource is requested
	Then the image resource should be displayed on the main window

@completed
Scenario:  Generate unique information for image resource
	Given an image resouce is requested
	When the resource is loaded
	Then the image resource should have an unique hash

@completed
Scenario:  Load a group of image resources from computer
	Given a group of images is requested
	When the group is loaded
	Then all the images on the group should be displayed on the main window
	And the images should have an unique hash

Scenario:  Add images to a group of image already loaded
	Given a group of images is requested
	And another image is selected
	When the new image is loaded
	Then all the images on the group should be displayed on the main window
	And the new image should be displayed

# Display Images
Scenario: Display selected image in fullscreen
	Given a group of images is already loaded
	When  one image is selected (double clicked)
	Then the image should be displayed in fullscreen

# Images properties
Scenario: Display selected image in fullscreen
	Given an image is already loaded
	When  one image is selected
	Then the image information should be displayed on the lateral
	| Alias    | Resolution | Size (Kb) | Location | Tags | Collection is in |
	| hardcore | 450x300    | 1024      | c:/imgs  | hc   | hardcore, tough  |  

# Resource Management
Scenario: Save image information on disk
	Given a images is already loaded
	When  the save button is clicked
	Then a file containing the image information should be saved on disk

# Tags
Scenario: Add new tag
	Given the tag list is being displayed
	And the new tag textbox is being displayed
	And a tag is inserted on the textbox
	When the 'addTag' button is pressed
	Then a new tag should be displayed in the list

Scenario: Add tag to an image
	Given a images is already loaded
	When  a tag is selected
	Then the image should store the tag on its information
