///////////////////////////////////////////////////////////////////////////////////////
"Interactive Water"�͎��VRChat�ł̎g�p��z�肵��Unity5.6.3p�̃p�b�P�[�W�ł��B
�ȉ��̗��p�K��ɏ]���Ďg�p���Ă��������B

�����p�K��
�E���e���͎��R�Ɏg�p�E���ς��Ă��������č\���܂���B
�E�Ĕz�z�̏ꍇ��twitter�܂ŘA����������(@rakuraku_vtube)
�E����̈��萫�͕ۏ؂ł��܂���B

///////////////////////////////////////////////////////////////////////////////////////
"Interactive Water" is Unity 5.6.3p package mainly assumed using in VRChat.
Follow terms of use:

��Terms of Use
�EYou are allowed use and modify items of this package.�@
�EIf you want to share this package or modified item of this package, please contact my twitter acount(@rakuraku_vtube).
�EOperational stability can not be guaranteed.


///////////////////////////////////////////////////////////////////////////////////////
���g�p���@
(VRChat�ł̎g�p�łȂ����1,2���΂�)
1.VRCSDK���C���|�[�g
2.�{�p�b�P�[�W���C���|�[�g
3.VRChat SDK --> Show Build Control Panel --> Set Up Layer
4."SimuBoard"-->Layer-->AddLayer����AUserLayer22��"Quad"��ǉ�
5."SimuBoard"��"DrawBoard"��Layer��"Quad"�ɐݒ�
6."SimCamera"��CullingMask��"Quad"�ɐݒ�
7."InterCamera"��CullingMask�𐅂ɉe����^���郌�C���[�ɐݒ�B(LocalPlayer,Player��)

���g�p�̃|�C���g
SimBoard��Inspector����V�F�[�_�[�̃p�����[�^�[���������ݒ�ł��܂��B
�����W���␅�̓`�����x��ς��Ȃ���ǂ������ڂɂȂ�悤�ɒ������ĉ������B
�ꍇ�ɂ���Ă͉������肹�������U�����Ă��܂��ꍇ������̂ŁA���̂Ƃ��͓`�����x�𗎂Ƃ��ĉ������B

���ʂ��L�������ꍇ��"DrawBoard"�̑傫����傫�����āA����ɍ��킹��"InterCamera"��Size��傫�����ĉ������B
���̍ۂɐ��̓`�����x�𑽏����Ƃ��Ɨǂ������ł��B


///////////////////////////////////////////////////////////////////////////////////////////
��HOW TO USE
1.Import VRCSDK 
2.Import this package.
3.VRChat SDK --> Show Build Control Panel --> Set Up Layer
4."SimuBoard"-->Layer-->AddLayer-->Add "Quad" on "User Layer22"
5.Set layer "Quad" to "SimuBoard" and "DrawBoard"
6.Set "Quad" to culling mask of "SimCamera"
7.Set the layer you want to use to interact water to culling mask of "InterCamera" 

You can tune simulation parameter throught inspector of "SimBoard".
If the stability of the calculation result of the water surface is lost, try lowering the propagation speed.

If you want to expand the surface of the water, increase the size of "DrawBoard" and increase the size of "InterCamera" accordingly.
In that case, it seems good to decrease the propagation speed of water.

/////////////////////////////////////////////////////////////////////////////////////////////

2018/7/04 �炭�Ƃ�����
Contact (Twitter:@rakuraku_vtube)