# Introduction #

Camera calibration is used to determine a set of parameters which are used to describe the mapping between the 3D environment and the produced 2D camera image.
These parameters can be subdivided into two groups.
  * The Intrinsic Camera Parameters describe the internal geometry of a camera including radial and tangential distortion coefficients.
  * The Extrinsic Camera Parameters describe the relation between the 3D camera coordinate system (located in the projection center) and a given world coordinate system (position and orientation).


The following chapter describes how to perform the intrinsic calibration with Parsley.

# Intrinsic Calibration #
Intrinsic Camera Parameters define the internal geometry of the camera. This parameter set includes the focal lengths, the principal point (image center) and the distortion coefficients (see [CoordinateSystems](CoordinateSystems.md)).
These parameters are independent of the camera position and orientation relative to the world coordinate system. The intrinsic calibration is used to reduce/eliminate the lense distortion. It is obvious that the extrinsic calibration **depends** on the results and the accuracy of the intrinsic calibration, since small distortion is essential for estimating the coordinate transformation matrix (combined rotation and translation between world  and camera 3d coordinate system) properly.

## Camera setup ##

In order to avoid the activation of the auto focusing functionality of the camera permanently, e.g. during changes of the lighting conditions or changes of the distance to the object of interest, use the [AMCap](http://www.noeld.com/programs.asp?cat=video#AMCap) software to deactivate _auto focusing_ and _auto exposure time_ functionalities.
Furthermore, make sure that the camera provides a frame rate of at least **15 fps**. If necessary, reduce the camera resolution to improve the frame rate.

## Intrinsic calibration settings in Parsley ##
After changing the camera hardware settings successfully we need to set up Parsley before the intrinsic calibration can be performed.
Firstly, go to the Parsley **PatternEditor** menu using the _Setup_ tab. The PatternEditor is used to create a pattern set, which is needed to perform intrinsic calibration and extrinsic calibration as well. Currently Parsley supports **Chessboard**, **Circle** and **Marker** patterns.

For the use of the chessboard pattern the below-mentioned parameters need to be set.
  * _Size_ defines the number of inner corners per row and column on the pattern.
  * _SizeOfSquare_ defines the size of the pattern's squares in the given unit (e.g. mm).

Using the circle pattern requires the following parameter settings.
  * _Size_ defines the number of circle centers per row and column on the pattern.
  * _CenterDistanceX_ defines the spacing between two circle centers in x-direction.
  * _CenterDistanceY_ defines the spacing between two circle centers in y-direction.
  * _BinaryThreshold_ sets the threshold which is used to create a binary image. Pixels with color values less or equal than the threshold will be set to black, all other pixels to white.
  * _MinimumContourCount_ sets the minimum number of detected contour points, necessary to attempt an ellipse fit.
  * _MeanDistanceThreshold_ defines the average allowed distance of contour points to the fitted ellipse.
  * _NumberOfCirclePoints_ sets the number of points of the elliptic path which is used to count the white-black pixel color transitions within the **marker ellipses**.
  * _MaximumEllipseDistance_ defines the maximum spacing between the detected ellipse center and the expected ellipse center.

Setting up a marker based pattern requires parameters as follows.
  * _BinaryThreshold_ sets the threshold which is used to create a binary image. Pixels with color values less or equal than the threshold will be set to black, all other pixels to white.
  * _MarkerImage_ determines, which marker image should be found.
  * _MarkerLength_ defines the size of the square marker in millimeters (standard value: 50mm).
  * _MaximumErrorNormed_ sets the maximum allowed error value for the pattern detection (reasonable value: 0.4).

The video [PatternDesigner](http://www.youtube.com/watch?v=63-njMWsunU) summarizes how to set up different pattern types.
For the intrinsic calibration, we recommend to use either chessboard patterns or circle patterns, since marker based patterns only permit **one** marker printed on the calibration plane.

Reasonable values for the given parameters, which were found out during several calibration test (circle pattern: Diameter = 40mm, Size = 5;4, CenterDistanceX = 55, CenterDistanceY = 50), are:
| **Parameter** | **Value** | **Unit** | **Description**|
|:--------------|:----------|:---------|:---------------|
| BinaryThreshold | 30 - 100 | color value | depends very much on the lighting conditions |
| MinimumContourCount | 40 | number of points | the more the angle between camera vision range and the pattern becomes sharp, the more decreases the number of contour points (perspective distortion) |
| MeanDistanceThreshold | 1 | length | demands high quality ellipse fitting algorithm|
| NumberOfCirclePoints | 50 - 100 (for resolution 960x720) | number of points | rising camera resolution leads to a rising need of circle points for a successful detection |
| MaximumEllipseDistance | 10 | length | use small values, since the distance between expected ellipse centers to the detected ellipse centers should be short |

Note, that changes in the Options menu will be safed automatically in the Parsley configuration file.
## Execution of the intrinsic calibration ##
Finally, after setting the configuration parameters, the intrinsic calibration can be performed using the _Intrinsic Camera Calibration_ slide of the _Setup_ tab.

In order to gain satisfying calibration results, several pictures of the choosen calibration pattern, taken from different viewing angles, are needed. Additionally it's recommended that the patten fits the major part of the cameras vision range, to include the border areas (where camera lens distortions are mainly visible) in the calibration process (e.g. use a circle pattern with 5x4 circles printed onto the calibration plane).

After taking about ten pictures from different viewing angles (either using the **Auto take image** functionality or taking the pictures manually), the intrinsic calibration can be performed by hitting the button _Calibrate_. If the calibration has been performed successfully, save the calibration data (watch the video [IntrinsicCalibration](http://www.youtube.com/watch?v=qE9ac0FVSik)).

Now the intrinsic calibration can be finished by setting the camera intrinsics property, using the _Parsley Options_ in the _Setup_ menu.
## Troubleshooting and hints regarding the Intrinsic Calibration Process ##
  * Before starting with the intrinsic calibration make sure, that any _auto focusing_ and _auto exposure_ functionalities are deactivated (use [AMCap](http://www.noeld.com/programs.asp?cat=video#AMCap)). Otherwise, if the camera changes its focusing settings, after the intrinsic calibration has been performed, you need to repeat the calibration.
  * If the chosen calibration pattern cannot be found during the calibration image taking process, try to change the pattern settings (using the _PatternEditor_). This problem might occur due to changing lighting conditions.